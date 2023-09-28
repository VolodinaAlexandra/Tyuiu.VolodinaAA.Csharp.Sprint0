using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Csharp.Sprint0.Task5.V0.Lib;

namespace Tyuiu.VolodinaAA.Csharp.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а + в = " + DataService.Addition(3, 9));
            Console.WriteLine("а - в = " + DataService.Substraction(38, 9));
            Console.WriteLine("а * в = " + DataService.Multiplication(3, 9));
            Console.WriteLine("а / в = " + DataService.Division(81, 3));
            Console.ReadKey();
        }
    }
}
