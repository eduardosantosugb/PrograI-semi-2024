using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
   Console.Write("Lab1: ");
double lab1 = double.Parse(Console.ReadLine()); //8
    Console.Write("Lab2: ");
double lab2 = double.Parse(Console.ReadLine()); //9
    Console.Write("Parcial 1: ");
double parcial1 = double.Parse(Console.ReadLine()); //7
    double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
    Console.WriteLine("La nota de C1 es: {0}", c1);



Console.Write("Ciclo 2   ");

Console.Write("Lab1: ");
lab1 = double.Parse(Console.ReadLine());

    Console.Write("Lab2: ");
lab2 = double.Parse(Console.ReadLine());

    Console.Write("Parcial 1: ");
parcial1 = double.Parse(Console.ReadLine());

    double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
    Console.WriteLine("La nota de C2 es: {0}", c2);


Console.Write("Ciclo 3   ");

Console.Write("Lab1: ");
lab1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Lab2: ");
lab2 = double.Parse(Console.ReadLine());

    Console.Write("Parcial 1: ");
parcial1 = double.Parse(Console.ReadLine());


    double c3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
    Console.WriteLine("La nota de C3 es {0}", c3);

double notaf = c1 + c2 + c3 / 3;
    Console.WriteLine(" la nota final de Progra 1 es : {0}", notaf);
}
