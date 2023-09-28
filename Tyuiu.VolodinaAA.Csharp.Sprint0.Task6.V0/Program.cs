using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Csharp.Sprint0.Task6.V0.Lib;
namespace Tyuiu.VolodinaAA.Csharp.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма эл-в массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность эл-в массива = " + DataService.SubstractionArray(numsArray));
            Console.WriteLine("Произведение эл-в массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
