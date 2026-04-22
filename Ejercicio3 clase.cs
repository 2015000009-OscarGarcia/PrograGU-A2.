using System;

class Program
{
    static void Main()
    {
        char letra;
        Console.Write("Ingrese la letra de su calificacion (a-f): ");
        letra = Console.ReadLine().ToLower()[0]; 

        switch (letra)
        {
            case 'a':
                Console.WriteLine("Excelente");
                break;
            case 'b':
                Console.WriteLine("Bueno");
                break;
            case 'c':
                Console.WriteLine("Regular");
                break;
            case 'd':
                Console.WriteLine("Deficiente");
                break;
            case 'f':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Letra no válida");
                break;
        }
    }
}