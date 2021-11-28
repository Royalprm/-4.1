using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите целое положительное число N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i;
            for (i = 1; i <= (2 * N - 1); i += 2) 
            {
                sum += i;
                Console.WriteLine("Значение суммы при шаге {0}", sum);
             }
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
         }
    }
}
