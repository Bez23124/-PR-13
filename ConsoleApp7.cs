using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {/// <summary>
     /// Найти s=min(a, b) + min(c, d),
     /// используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
     /// </summary>
     /// <param name="args"></param>
        static int Input(string message)
        {
                Console.WriteLine(message);
                return int.Parse(Console.ReadLine());
            }
            static int Min(int a, int b)
            {
                return a < b ? a : b;
            }
            static void Output(int result)
            {
                Console.WriteLine($"result = {result}");
            }
            static void Main(string[] args)
            {
                int a = Input("a=");
                int b = Input("b=");
                int s = Input("s=");
                int c = Input("c=");
                int result = Min(a, b) + Min(s, c);
                Output(result);
                Console.ReadKey();
            }
    }
}
