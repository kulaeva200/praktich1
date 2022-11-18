using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        static void Main(string[] args)
        {
            float a, b, sum;

            Console.WriteLine("Введите первое число для сложения:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число для сложения:");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("Сумма данных чисел:");
            Console.WriteLine(sum);
            float y, z, x;
            Console.WriteLine("Введите первое число для произведения:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число для произведения:");
            z = Convert.ToInt32(Console.ReadLine());
            x = y * z;
            Console.WriteLine("Произведение данных чисел:");
            Console.WriteLine(x);
            Console.ReadLine();


        }
    }
}
