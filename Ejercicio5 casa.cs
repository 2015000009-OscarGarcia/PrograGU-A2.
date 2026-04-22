using System;

class Program {
    static void Main() {
        double precio = 650.00;
        double precioIva = precio * 1.12;

        Console.Write("Cantidad de impresores a comprar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Forma de pago: \n1.Efectivo (10%)\n2.Tarjeta (5%)\n3.Vale de regalo(15%)");
        int forma = Convert.ToInt32(Console.ReadLine());

        double subtotal = precioIva * cantidad;
        double descuentoPorcentaje = 0;
        string nombrePago = "";

        switch (forma) {
            case 1: descuentoPorcentaje = 0.10; Pago = "Efectivo"; break;
            case 2: descuentoPorcentaje = 0.05; Pago = "Tarjeta de crédito"; break;
            case 3: descuentoPorcentaje = 0.15; Pago = "Vale de regalo"; break;
        }

        double descuentoMonto = subtotal * descuentoPorcentaje;
        double totalFinal = subtotal - descuentoMonto;

        Console.WriteLine("\nFactura");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Precio Unitario (con IVA): Q{precioIva}");
        Console.WriteLine($"Total sin descuento: Q{subtotal}");
        Console.WriteLine($"Forma de pago: {Pago}");
        Console.WriteLine($"Descuento realizado: Q{descuentoMonto}");
        Console.WriteLine($"TOTAL A PAGAR: Q{totalFinal}");
    }
}