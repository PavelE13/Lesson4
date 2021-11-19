using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add3_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Ввод и инициализация данных
            Console.WriteLine("Программа расчета количества квадратов, вложенных в прямоугольник, без наложения");
            Console.WriteLine("Введите длины сторон прямоугольника А (длина), B (ширина) и длину квадрата C.");
            Console.Write("А=");
            int a = Convert.ToByte(Console.ReadLine());
            Console.Write("B=");
            int b = Convert.ToByte(Console.ReadLine());
            Console.Write("C=");
            int c = Convert.ToByte(Console.ReadLine());
            int x = c, y = c, i = 0, n = 0, N; //Ввод дополнительных переменных для сравнения по длине x и ширине y, объявление счетчиков i,n, результирующей переменной N
            #endregion
            if (a>=c && b>=c)
            {
                do //Определение кол-ва квадратов по длине
                {
                    i++; //счетчик кол-ва квадратов по длине
                    x = x + c; //суммарная длина помещаемых квадратов со стороной С
                } while (x <= b); // условие, при котором выполняется цикл
                do //Определение кол-ва квадратов по ширине
                {
                    n++; // счетчик кол - ва квадратов по ширине
                    y = y + c; //суммарная ширина помещаемых квадратов со стороной С
                } while (y <= a); // условие, при котором выполняется цикл
                N = i * n;
            Console.WriteLine("Количество квадратов, вписанных в прямоугольник, с длинной стороны {0} = {1} шт.", c, N);
            Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка!Длина стороны вписываемого квадрата {0} не может быть больше длин сторон прямоугольника {1} и {2}.", c, a, b);
                Console.ReadKey();
            }
        }
    }
}
