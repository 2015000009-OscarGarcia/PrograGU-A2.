using System;

class Program {
    static void Main() {
        Console.WriteLine("Sectores: \n1.Palco (Q300)\n 2.Tribuna (Q125)\n 3.Preferencia (Q75)\n 4.Generales (Q50)");
        int sector = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de entradas: ");
        int cant = Convert.ToInt32(Console.ReadLine());
        double precio = 0;

        switch (sector) {
            case 1: precio = 300; break;
            case 2: precio = 125; break;
            case 3: precio = 75; break;
            case 4: precio = 50; break;
        }
        
        Console.WriteLine($"Total a pagar: Q{precio * cant}");
    }
}