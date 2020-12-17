using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            ClassFirst numberManipulator = new ClassFirst();


            Console.WriteLine("Введите число - X");
            string x = Console.ReadLine();
            Console.WriteLine("Введите число - Y");
            string y = Console.ReadLine();

            int xInt = Convert.ToInt32(x);
            int yInt = Convert.ToInt32(y);


            result = numberManipulator.FindMax(xInt, yInt);

            if (result == xInt)
            {
                Console.WriteLine($"Число: X-{xInt} > Y-{yInt}");
            }
            else
            {
                Console.WriteLine($"Число: X-{xInt} < Y-{yInt}");
            }

            Console.ReadKey();
        }
    }
}
