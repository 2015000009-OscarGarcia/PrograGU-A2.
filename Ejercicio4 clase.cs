using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("MENÚ DE COMIDA");
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Pizza");
        Console.WriteLine("3. Pollo frito");
        Console.WriteLine("4. Ensalada");
        Console.Write("Ingrese el número de su pedido (1-4): ");
        int pedido = Convert.ToInt32(Console.ReadLine());
        string platillo = "";

        switch (pedido)
        {
            case 1:
                platillo = "Hamburguesa";
                break;
            case 2:
                platillo = "Pizza";
                break;
            case 3:
                platillo = "Pollo frito";
                break;
            case 4:
                platillo = "Ensalada";
                break;
            default:
                Console.WriteLine("Pedido no válido");
                break;
        }

        Console.WriteLine($"Su pedido ha sido una: {platillo}");
    }
}