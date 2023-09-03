using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// using Empresa;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Dar de alta pedido");
            Console.WriteLine("2. Asignar pedido a cadete");
            Console.WriteLine("3. Cambiar estado de pedido");
            Console.WriteLine("4. Reasignar pedido a otro cadete");
            Console.WriteLine("5. Mostrar informe de pedidos");
            Console.WriteLine("6. Salir");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    break;

                case 2:
                    
                    break;

                case 3:
                    
                    break;

                case 4:
                    
                    break;

                case 5:
                    
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

}  