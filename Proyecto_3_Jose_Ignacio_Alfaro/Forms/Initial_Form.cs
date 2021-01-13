
using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_3_Jose_Ignacio_Alfaro
{
    public partial class Form1 : Form
    {
        private int dataLength;
        private List<string> groups = new List<string>();
        

        public Form1()
        {
            InitializeComponent();

        }


        

        private void generateKnowledge(string knowledge)
        {

            PlQuery plQuery = new PlQuery("generateKnowLedge(" + knowledge + ")");
            if (plQuery.NextSolution())
            {
                plQuery.Dispose();
                   
            }

            btnAutomatic.Enabled = false;
            btnGenerateKnow.Enabled = false;
            panel2.Enabled = true;
            button2.Enabled = true;

                
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            //Se debe de cambiar la ruta del bin en donde se encuentre instalado Prolog (bin)
            Environment.SetEnvironmentVariable("Path", @"D:\\Aplicaciones\\swipl\\bin");
            
            string[] prolog_path = { "-q", "-f", @"proyecto3_Ignacio.pl" }; //No modificar
            PlEngine.Initialize(prolog_path); //No modificar

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                dataLength = Int32.Parse(txtLength.Text);
                
                if( dataLength >= 1 && dataLength <= 10 )
                {
                    dataGrid.AutoResizeColumns();
                    dataGrid.AutoResizeRows();



                    for (int i = 0; i < dataLength; i++)
                    {
                        dataGrid.Columns.Add(i.ToString(), i.ToString());

                        if (i != 0)
                        {
                            dataGrid.Rows.Add();
                        }
                    }

                    button1.Enabled = false;
                    txtLength.Enabled = false;
                    btnAutomatic.Enabled = true;
                    btnGenerateKnow.Enabled = true;


                }else
                {
                    MessageBox.Show("El tamaño máximo para la matriz es de 10");
                }



            }
            catch
            {
                
                MessageBox.Show("Necesita ingresar un número válido");
            }


        }


        private void setValue(int x, int y)
        {
            if ( btnGenerateKnow.Enabled )
            {
                if (dataGrid.Rows[x].Cells[y].Value != null)
                {
                    dataGrid.Rows[x].Cells[y].Value = null;
                }
                else
                {
                    dataGrid.Rows[x].Cells[y].Value = "O";
                }
            }else
            {
                groupClick( x, y  );
            }
        }


        private void gdvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGrid.CurrentRow.Index;
            int cellIndex = dataGrid.CurrentCell.ColumnIndex;
            setValue(rowIndex, cellIndex);
        }

        

        private void btnAutomatic_Click(object sender, EventArgs e) // Button to fill datagrid automatically
        {

            Random random = new Random();


            for (int i = 0; i < dataLength; i++)
            {
                int rowValue = random.Next(dataLength);
                int colValue = random.Next(dataLength);

                setValue(rowValue, colValue);

            }

        }


        private void button2_Click(object sender, EventArgs e) //Loading the knowledge into Prolog file
        {
            for (int i = 0; i < dataLength; i++)
            {
                for (int j = 0; j < dataLength; j++)
                {
                    if (dataGrid.Rows[i].Cells[j].Value != null)
                    {
                        string knowledge = "conectado(" + i + "," + j + ")";
                        generateKnowledge(knowledge);

                        
                    }
                }
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e) //Cleaning the datagrid
        {
            matrixClean();
            PlQuery plQuery = new PlQuery("clean");
            if (plQuery.NextSolution())
            {
                plQuery.Dispose();

            }

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    cell.Value = null;
                }

            }

            richGroupResponse.Text = "";
            panel2.Enabled = false;
            btnAutomatic.Enabled = true;
            btnGenerateKnow.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            groups.Clear();
            lbGroups.Items.Clear();


        }

        private void groupClick( int xPosition, int yPosition) //Getting the group - Prolog
        {
            if (dataGrid.Rows[xPosition].Cells[yPosition].Value != null)
            {
                List<string> prologResponse = new List<string>();

                PlQuery plQuery = new PlQuery("buscarBloqueAux(" + xPosition + "," + yPosition + ",X,Y,[],P)");
                foreach (PlQueryVariables path in plQuery.SolutionVariables)
                {
                    string response = path["P"].ToString();
                    if (!prologResponse.Contains(response))
                    {
                        prologResponse.Add(response);
                    }
                }

                plQuery.Dispose();
                matrixPaint(prologResponse);
                richGroupResponse.Text = "El grupo resaltado en la matriz tiene un total de: \n" + prologResponse.Count + " conexion(es).";
            }
            else
            {
                MessageBox.Show("La coordenada clickeada no posee dato, verifique e intente de nuevo");
                richGroupResponse.Text = "";
            }
        }

        
        private void button3_Click(object sender, EventArgs e) //Getting all the groups - Prolog and Filtering
        {
            List<string> lista = new List<string>();
            int conteo = 0;
            
          
            for (int i = 0; i < dataLength; i++)
            {     
                for (int j = 0; j < dataLength; j++)
                {

                    if (dataGrid.Rows[i].Cells[j].Value != null && (string) dataGrid.Rows[i].Cells[j].Value == "O")
                    {

                        PlQuery plQuery = new PlQuery("buscarBloqueAux(" + i + "," + j + ",X,Y,[],P)");
                        string pat = "";
                        foreach (PlQueryVariables path in plQuery.SolutionVariables)
                        {

                            string group = path["P"].ToString();
                            if (!lista.Contains(group))
                            {
                                pat += group + ".";
                                lista.Add(group);
                            }
                            
                        }

                        conteo++;
                        groups.Add(pat.Remove(pat.LastIndexOf('.')));
                        lbGroups.Items.Add("Grupo #" + conteo);
                        setDataGrid(lista);    
                        lista.Clear();
                    }
                    button3.Enabled = false;
                    
                    
                }

            }
            totalGroups();
            
        }


        private void totalGroups()
        {


            if ( groups.Count != 0)
            {
                int[] groups_count = new int[100];
                String groupsInformation = "Conteo total de grupos \n\n";

                foreach (String item in groups)
                {
                    String[] groupTotal = item.Split('.');
                    groups_count[groupTotal.Length] += 1;
                }

                for (int i = 0; i < groups_count.Length; i++)
                {
                    if (groups_count[i] > 0)
                    {
                        groupsInformation += "Grupos con tamaño de " + i + " hay un total de " + groups_count[i] + "\n"; 
                    }
                }

                MessageBox.Show(groupsInformation);
            }
            else
            {
                MessageBox.Show("La lista de grupos está vacía, primero debes de generar uno");
            }
        }


        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e) //List view
        {

            string[] selectedGroup = groups[lbGroups.SelectedIndex].Split('.');
            List<string> listGroup = selectedGroup.OfType<string>().ToList();
            richGroupResponse.Text = "El tamaño del grupo seleccionado es de: " + listGroup.Count;
            matrixPaint(listGroup);
        }

        private void matrixPaint(List<string> prologResponse) //Painting datagrid with prolog response
        {
            matrixClean();
            for (int i = 0; i < prologResponse.Count; i++)
            {
                dataGrid.Rows[int.Parse(prologResponse[i][1].ToString())].Cells[int.Parse(prologResponse[i][3].ToString())].Style.BackColor = Color.Yellow;
            }
        }

        private void matrixClean() //Cleaning the data grid
        {
            for (int i = 0; i < dataLength; i++)
            {
                for (int j = 0; j < dataLength; j++)
                {
                    dataGrid.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void setDataGrid(List<String> lista) //Filtering the information prolog
        {
            for (int i = 0; i < lista.Count; i++)
            {
                dataGrid.Rows[int.Parse(lista[i][1].ToString())].Cells[int.Parse(lista[i][3].ToString())].Value = "X";

            }
        }

       


    }


}
