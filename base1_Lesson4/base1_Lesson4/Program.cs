using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N"); //Ввод данных и инициализация переменных
            int squareN = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            #region // Расчет квадрата на основе суммы чисел типа N=(2i-1)
            for (int i = 1; i < squareN; i++)
            {
                n2 = n2 + (2 * i - 1);
                Console.WriteLine("Квадрат числа N2 = {0} при N= {1}", n2, i);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
