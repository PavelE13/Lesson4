using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел N. 0 - выход"); //Ввод данных и инициализация переменных
            int zeroCatch;
            int countPos=0, countNeg=0;
            #region // Сравнение вводимых чисел, сортировка на + и - {весы}
            do
            {
                zeroCatch = Convert.ToInt32(Console.ReadLine());
                if (zeroCatch > 0)
                {
                    countPos++;
                }
                else
                {
                    if (zeroCatch == 0)
                    {
                        Console.WriteLine("Выход!"); 
                    }
                    else
                    {
                        countNeg++;
                    }   
                }
            } while (zeroCatch != 0);
            #endregion
            Console.WriteLine("Положительных чисел = {0}, отрицательных= {1}", countPos, countNeg);
            Console.ReadKey();
        }
    }
}
