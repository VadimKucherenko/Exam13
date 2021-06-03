using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_13
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Среднє арифметичне: " + ((a + b + c) / 3).ToString());
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введить 1 зачення");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введить 2 значення");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введить 3 значення");
            c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c);
        }

    }
}
