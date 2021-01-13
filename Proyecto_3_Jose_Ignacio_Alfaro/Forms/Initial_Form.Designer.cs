
namespace Proyecto_3_Jose_Ignacio_Alfaro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGenerateKnow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutomatic = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.richGroupResponse = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la matriz a generar\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.Window;
            this.txtLength.Location = new System.Drawing.Point(51, 55);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtLength.MaxLength = 2;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(195, 22);
            this.txtLength.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(47, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.button1, "Generar la matriz");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGenerateKnow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAutomatic);
            this.panel1.Controls.Add(this.d);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 497);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Limpiar la memoria";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(47, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnGenerateKnow
            // 
            this.btnGenerateKnow.Enabled = false;
            this.btnGenerateKnow.Location = new System.Drawing.Point(47, 261);
            this.btnGenerateKnow.Name = "btnGenerateKnow";
            this.btnGenerateKnow.Size = new System.Drawing.Size(199, 34);
            this.btnGenerateKnow.TabIndex = 5;
            this.btnGenerateKnow.Text = "Guardar";
            this.btnGenerateKnow.UseVisualStyleBackColor = true;
            this.btnGenerateKnow.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-8, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "*  *  *  *  *  *  *  *  *  * ";
            // 
            // btnAutomatic
            // 
            this.btnAutomatic.Enabled = false;
            this.btnAutomatic.Location = new System.Drawing.Point(47, 198);
            this.btnAutomatic.Name = "btnAutomatic";
            this.btnAutomatic.Size = new System.Drawing.Size(199, 41);
            this.btnAutomatic.TabIndex = 4;
            this.btnAutomatic.Text = "Llenar automáticamente";
            this.btnAutomatic.UseVisualStyleBackColor = true;
            this.btnAutomatic.Click += new System.EventHandler(this.btnAutomatic_Click);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(3, 151);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(360, 44);
            this.d.TabIndex = 3;
            this.d.Text = "*  *  *  *  *  *  *  *  *  * ";
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Location = new System.Drawing.Point(632, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(625, 446);
            this.dataGrid.TabIndex = 4;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvData_CellClick);
            // 
            // richGroupResponse
            // 
            this.richGroupResponse.AcceptsTab = true;
            this.richGroupResponse.EnableAutoDragDrop = true;
            this.richGroupResponse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richGroupResponse.Location = new System.Drawing.Point(314, 344);
            this.richGroupResponse.Name = "richGroupResponse";
            this.richGroupResponse.ReadOnly = true;
            this.richGroupResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richGroupResponse.Size = new System.Drawing.Size(263, 155);
            this.richGroupResponse.TabIndex = 9;
            this.richGroupResponse.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(308, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 95);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Grupos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mostrar total grupos";
            // 
            // lbGroups
            // 
            this.lbGroups.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 16;
            this.lbGroups.Location = new System.Drawing.Point(314, 141);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(165, 180);
            this.lbGroups.TabIndex = 0;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1313, 536);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richGroupResponse);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutomatic;
        private System.Windows.Forms.Button btnGenerateKnow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richGroupResponse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbGroups;
    }
}

