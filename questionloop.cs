using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's one plus one?");

            int Answer = int.Parse(Console.ReadLine());
            if (Answer == 2)
            {
                Console.WriteLine("Smarty");
            }
            else
            {
                do
                {
                    Console.WriteLine("WRONG");
                    Console.WriteLine("What's one plus one?");

                    Answer = int.Parse(Console.ReadLine());
                    if (Answer == 2)
                    {
                        Console.WriteLine("Smarty");
                    }
                } while (Answer != 2);
                

            }
            Console.Read();
        }
    }
}
