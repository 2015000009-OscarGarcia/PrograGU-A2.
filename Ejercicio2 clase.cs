using System;

class Program
{
    static void Main()
    {
        double valor1, valor2, resultado;
        int opcion;

        Console.Write("Dame el primer numero: ");
        valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dame el segundo numero: ");
        valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nOpciones:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        Console.Write("Elige una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                resultado = valor1 + valor2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;
            case 2:
                resultado = valor1 - valor2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;
            case 3:
                resultado = valor1 * valor2;
                Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                break;
            case 4:
                resultado = valor1 / valor2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}