Algoritmo Ejercicio4_En_Casa
	Definir metros Como Real
	Definir opcion1 Como Caracter
	
	Escribir "Ingrese la cantidad en Metros:"
	Leer metros
	
	Escribir "Elija la unidad de destino:"
	Escribir "a) Pies"
	Escribir "b) Centímetros"
	Escribir "c) Pulgadas"
	Leer opcion1
	opcion1 = Minusculas(opcion1)
	
	Segun opcion Hacer
		"a": Escribir metros, " metros son ", metros * 3.28084, " pies"
		"b": Escribir metros, " metros son ", metros * 100, " centímetros"
		"c": Escribir metros, " metros son ", metros * 39.3701, " pulgadas"
		De Otro Modo:
			Escribir "Opción no válida"
	FinSegun
FinAlgoritmo