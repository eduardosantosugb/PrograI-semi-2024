using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto { }
internal class Program
{
    static void Main(string[] args)
    {
        Conversores objconverores = new Conversores();
        string continuar = "s";
        {
            while (continuar == "s")
            {
                Console.WriteLine(":::::...Menu...::::");
                Console.WriteLine("1. Monedas. ");
                Console.WriteLine("2. longitud. ");
                Console.WriteLine("3. Masa. ");
                Console.WriteLine("3. Tiempo. ");
                Console.WriteLine("0. salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 0)
                {
                    continuar = "n";
                }
                else
                {
                    int i = 1;
                    foreach (string etiqueta in objconverores.etiquetas[opcion - 1])
                    {
                        Console.WriteLine("{0}.  {1}", i++, etiqueta);
                    }
                    Console.Write("De: ");
                    int de = int.Parse(Console.ReadLine());
                    Console.Write("A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad:");
                    double cantidad = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} \n", objconverores.convertir(de, a, cantidad, opcion));

                }
            }
        }
    }
}

                     
           

