using System;

class Tarea04_1a3
{
    static void Main()
    {///PEDIDA DE NOMBRE Y ACCESO 04.01
        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();
        if (nombre == "Brandon")
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("!Acceso denegado¡");
        }
        ///NUMEROS ENTERO Y DIVISIÓN 04.02

        Console.Write("Dime  un número :");
        int numerador = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime otro: ");
        int denominador = Convert.ToInt32(Console.ReadLine());

        if (denominador != 0)
        {
            Console.Write("Su división es ");
            Console.WriteLine(numerador / denominador);
        }
        else
        {
            Console.WriteLine("No puedo dividir entre cero");
        }
        ///NUMEROS POSITIVOS 04.03
        Console.Write("Dime un número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime otro número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if ((numero > 0) && (numero2 > 0))
        {
            Console.WriteLine("Los dos son positivos");
        }
        else if (numero > 0)
        {
            Console.WriteLine("No es positivo");
        }
        else if (numero2 > 0)
        {
            Console.WriteLine("No es positivo");
        }
        if (numero > 0)
        {
            Console.WriteLine("Es positivo");
        }

        if (numero2 > 0)
        {
            Console.WriteLine("Es positivo");
        }


    }

}