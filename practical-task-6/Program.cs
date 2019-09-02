using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальный элемент для массива RangeOfArray");
            int minElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальный элемент для массива RangeOfArray");
            int maxElement = int.Parse(Console.ReadLine());

            RangeOfArray mas = new RangeOfArray(minElement, maxElement);

            for(int i = mas.MinIndex; i < mas.MaxIndex; i++)
            {
                mas[i] = i;
                Console.WriteLine("элемент массива под индексом[{0}] - {1}", i, mas[i]);
            }
            Console.ReadKey();
        }
    }
}
