Algoritmo Ejercicio2_En_Casa
	Definir car Como Caracter
	Escribir "Ingrese un carácter: "
	Leer car
	car = Minusculas(car) 
	
	Segun car Hacer
		"a", "e", "i", "o", "u":
			Escribir "Es una vocal"
		"0", "1", "2", "3", "4", "5", "6", "7", "8", "9":
			Escribir "Es un dígito"
		De Otro Modo:
			Escribir "Ninguno de los anteriores"
	FinSegun
FinAlgoritmo