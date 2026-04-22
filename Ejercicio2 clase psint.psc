Algoritmo Ejercicio2_En_Clase
	Definir valor1, valor2, opcion1 Como Real
	Escribir "Dame el primer numero: "
	Leer valor1
	Escribir "Dame el segundo numero: "
	leer valor2
	Escribir "Opciones: "
	Escribir "suma(1)"
	Escribir "resta(2)"
	Escribir "multiplicacion(3)"
	Escribir "division(4)"
	Leer opcion1
	Segun opcion1 Hacer
		1: s = valor1 + valor2
			Escribir "el resultado de la suma es: ",s
		2: r = valor1 - valor2
			Escribir "el resultado de la resta es ",r
		3: m = valor1 * valor2
			Escribir "el resultado de la multiplicacion es: ",m
		4: d = valor1 / valor2
			Escribir "el resultado de la division es: ",d	
		De Otro Modo:
			Escribir "opcion no valida"
	FinSegun
FinAlgoritmo
