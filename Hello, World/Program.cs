using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__World
{
    class Program
    {
        private static string name;
        static void Main(string[] args)
        {
            name = Name();
            Date();
            End();

            string Name()
            {
                Console.WriteLine("Enter, you name!");
                return Console.ReadLine();

            }

            void Date()
            {
                Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}]");
            }

            void End()
            {
                for (int i = 10; i > -1; i--)
                {
                    Console.Write($" {i} секунд до закрытия программы");
                    Console.Write("\r");
                    Thread.Sleep(1000);
                }

            }

        }
        
    }
}
