using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Csharp.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VolodinaAA.Csharp.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма = "+DataService.Addition(3, 5));
            Console.WriteLine("Разность = "+DataService.Substraction(3, 5));
            Console.WriteLine("Произведение = "+DataService.Multiplication(3, 5));
            Console.WriteLine("Частное = "+DataService.Division(5,5));
            Console.ReadKey();
        }
    }
}
