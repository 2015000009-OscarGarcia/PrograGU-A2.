Algoritmo Ejercicio3_En_Casa
	Definir sector, cantidad Como Entero
	Definir precio, total Como Real
	
	Escribir "Sectores del Estadio:"
	Escribir "1. Palco (Q300)"
	Escribir "2. Tribuna (Q125)"
	Escribir "3. Preferencia (Q75)"
	Escribir "4. Generales (Q50)"
	Escribir "Seleccione el sector (1-4):"
	Leer sector
	
	Escribir "Ingrese la cantidad de entradas:"
	Leer cantidad
	
	Segun sector Hacer
		1: precio = 300
		2: precio = 125
		3: precio = 75
		4: precio = 50
		De Otro Modo:
			Escribir "Sector no válido"
			precio = 0
	FinSegun
	
	total = precio * cantidad
		Escribir "El total a pagar por ", cantidad, " entradas es: Q", total
FinAlgoritmo