using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.VolodinaAA.Csharp.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne,int[] numTwo)//два одномерных целочисленных массива в качестве аргументов
        {
            int[] resultArray = new int[5];//создаем одномерный целочисленный массив на 5 элементов
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
