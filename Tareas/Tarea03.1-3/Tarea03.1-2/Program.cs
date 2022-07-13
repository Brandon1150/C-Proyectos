using System;



    internal class Tarea03_1a3
{
        static void Main()
        {
        string nombre;
        double numero1, numero2;
        int numero3, numero4;

        Console.Write("¿Cuál es tu nombre?:");
        nombre = Console.ReadLine();

        Console.WriteLine("Dime un número real:");
        numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dime otro número real:");
        numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dime un número entero:");
        numero3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro número entero:");
        numero4 = Convert.ToInt32(Console.ReadLine());





        Console.Write("Bienvenido");
        Console.WriteLine(nombre);
        Console.Write("La división delos números reales es:");
        Console.WriteLine(numero1/numero2);
        Console.Write("La división de los número enteros es:");
        Console.WriteLine(numero3/numero4);
        Console.Write("El resto de los números enteros es:");
        Console.WriteLine(numero3 % numero4);




        
        }
    }

