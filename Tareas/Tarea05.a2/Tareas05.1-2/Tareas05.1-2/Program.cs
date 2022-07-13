using System;

 

    internal class Tareas05_1a2
{
        static void Main()
        {
            Console.WriteLine("Dime un número!");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {

            case 1:
                Console.WriteLine("Enero");
                break;

            case 2:
                Console.WriteLine("Febrero");
                break;
            case 3:
                Console.WriteLine("Marzo");
                break;
           
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Mayo");
                break;
            
            case 6:
                Console.WriteLine("Junio");
                break;
            
            case 7:
                Console.WriteLine("Julio");
                break;
            
            case 8:
                Console.WriteLine("Agosto");
                break;
            
            case 9:
                Console.WriteLine("Septiembre");
                break;
            
            case 10:
                Console.WriteLine("Octubre");
                break;
            
            case 11:
                Console.WriteLine("Noviembre");
                break;

            case 12:
                Console.WriteLine("Diciembre");
                break;

             
            default:
                Console.WriteLine("No es un mes");
                break;


        }

        Console.WriteLine("Dime un mes");
        string numeromes = Console.ReadLine();

        switch (numeromes)
        {

            case "Enero":
                Console.WriteLine("31");
                break;

            case "Febrero":
                Console.WriteLine("28");
                break;
            case "Marzo":
                Console.WriteLine("31");
                break;

            case "Abril":
                Console.WriteLine("30");
                break;
            case "Mayo":
                Console.WriteLine("31");
                break;

            case "Junio":
                Console.WriteLine("30");
                break;

            case "Julio":
                Console.WriteLine("30");
                break;

            case "Agosto":
                Console.WriteLine("31");
                break;

            case "Septiembre":
                Console.WriteLine("30");
                break;

            case "Octubre":
                Console.WriteLine("29");
                break;

            case "Noviembre":
                Console.WriteLine("30");
                break;

            case "Diciembre":
                Console.WriteLine("31");
                break;


            default:
                break;
        }



    }
    }

