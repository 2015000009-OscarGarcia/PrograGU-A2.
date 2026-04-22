Algoritmo Ejercicio5_En_Casa
	Definir cantidad, formaPago Como Entero
	Definir precio, precioIva, subtotal, descuento, total Como Real
	Definir Pago Como Caracter
	
	precio = 650
	precioIva = precio * 1.12 
	
	Escribir "Cantidad de impresores a comprar:"
	Leer cantidad
	
	Escribir "Forma de pago:"
	Escribir "1. Efectivo (10% desc)"
	Escribir "2. Tarjeta de crédito (5% desc)"
	Escribir "3. Vale de regalo (15% desc)"
	Leer formaPago
	
	subtotal = precioIva * cantidad
	
	Segun formaPago Hacer
		1: 
			descuento = subtotal * 0.10
			Pago = "Efectivo"
		2: 
			descuento = subtotal * 0.05
			Pago = "Tarjeta de Crédito"
		3: 
			descuento = subtotal * 0.15
			Pago = "Vale de Regalo"
		De Otro Modo:
			Escribir "Opción de pago inválida"
			descuento = 0
	FinSegun
	
	total = subtotal - descuento
	
	
	Escribir "Factura"
	Escribir "Cantidad comprada: ", cantidad
	Escribir "Precio unitario (con IVA): Q", precioIva
	Escribir "Total sin descuento: Q", subtotal
	Escribir "Forma de pago: ", Pago
	Escribir "Descuento aplicado: Q", descuento
	Escribir "TOTAL A PAGAR: Q", total
FinAlgoritmo