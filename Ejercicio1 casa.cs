using System;

class Program {
    static void Main() {
        Console.Write("Ingrese el ángulo en grados: ");
        double grados = Convert.ToDouble(Console.ReadLine());
        double rad = grados * (Math.PI / 180);

        Console.WriteLine("1- Seno\n2- Coseno\n3- Tangente");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op) {
            case 1: Console.WriteLine($"Seno: {Math.Sin(rad)}"); break;
            case 2: Console.WriteLine($"Coseno: {Math.Cos(rad)}"); break;
            case 3: Console.WriteLine($"Tangente: {Math.Tan(rad)}"); break;
            default: Console.WriteLine("Opción inválida"); break;
        }
    }
}