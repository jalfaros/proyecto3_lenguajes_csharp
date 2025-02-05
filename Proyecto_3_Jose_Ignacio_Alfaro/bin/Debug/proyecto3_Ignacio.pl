:- dynamic conectado/2.



%Genera el nuevo conocimiento dentro del archivo.
generateKnowLedge(X):-
	assert(X).

% Limpiar la base de los conocimientos para probar otra distribucion de
% conocimientos

clean:-retractall(conectado(_,_)).


%Codigo para buscar la cantidad de conexiones que tiene un bloque
%Esta misma función se utiliza para buscar todos los grupos que
% se encuentran en la cuadrícula ya que esta misma devuelve por llamada
% cada path de conexión, por lo que para facilidad decidi manejar el
% total de grupos por cuadricula con la misma función.

%Funcion de busqueda de adyacente
adyacente(X0,Y0,X0,Y) :- Y is Y0+1.
adyacente(X0,Y0,X,Y0) :- X is X0+1.
adyacente(X0,Y0,X0,Y) :- Y is Y0-1.
adyacente(X0,Y0,X,Y0) :- X is X0-1.

%Busca los adyacentes y pregunta si esta conectado
buscarAdyacente(X0,Y0,X,Y) :-
	        adyacente(X0,Y0,X,Y),
	        conectado(X,Y).


%Funcion que se llama desde C#
buscarBloqueAux(X,Y,Z,W,[],P) :-
	buscarBloque(X,Y,Z,W,[],P).

%Caso base
buscarBloque(X,Y,X,Y,_,[X,Y]).

% Si no esta en la lista que lo agregue, evita repeticiones utiliza la
% escencia del "visitado" en grafos
%
buscarBloque(X0,Y0,X,Y,Camino,Path) :-
    buscarAdyacente(X0,Y0,X1,Y1),
    not(member([X1,Y1], Camino )),
    buscarBloque(X1,Y1,X,Y,[[X1,Y1]|Camino],Path).

























