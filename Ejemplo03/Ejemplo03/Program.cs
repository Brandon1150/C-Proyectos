using System;



class Ejemplo03
 {
        static void Main()
        {

        string nombre;
        int numero1, numero2;
        double numero3;

        Console.Write("Dime tu nombre:");
        nombre = Console.ReadLine();
       
        Console.Write("Dime un número:");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime otro número:");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime un número mas (real):");
        numero3 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Hola,");
        Console.WriteLine(nombre); 
        Console.Write("La suma es"); 
        Console.WriteLine(numero1+numero2);
        Console.Write("El cuadrado del último número es");
        Console.WriteLine(numero3 * numero3); 
    
        }
 }

