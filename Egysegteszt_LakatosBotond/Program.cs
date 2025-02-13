using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_LakatosBotond
{
    public class Rectangle
    {
        public int CalculateArea(int width, int height)
            {
                if (width <= 0 || height <= 0)
                {
                    throw new ArgumentException("A szélességnek és magasságnak pozitívnak kell lennie.");
                }
                return width * height;
            }

            static void Main()
        {
            int width, height;
            ConsoleKey key;
            do
            {
                Console.Write("A téglalap egyik oldala: ");
                width = int.Parse(Console.ReadLine());
                Console.Write("A téglalap másik oldala: ");
                height = int.Parse(Console.ReadLine());

                var teglalap = new Rectangle();

                Console.WriteLine($"{teglalap.CalculateArea(width, height)}");
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
