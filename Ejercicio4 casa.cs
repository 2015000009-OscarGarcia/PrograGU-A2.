using System;

class Program {
    static void Main() {
        Console.Write("Ingrese medida en metros: ");
        double mt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Convertir a: \na)Pies, \nb)Centímetros, \nc)Pulgadas");
        char op = Console.ReadLine().ToLower()[0];

        switch (op) {
            case 'a': Console.WriteLine($"{mt * 3.28084} pies"); break;
            case 'b': Console.WriteLine($"{mt * 100} cm"); break;
            case 'c': Console.WriteLine($"{mt * 39.3701} pulgadas"); break;
            default: Console.WriteLine("Opcion no valida"); break;
        }
    }
}