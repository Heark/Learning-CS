using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1 };

            for (int i = 0; i < 9999; i++)
            {
                if( i == 5000 ) {
                    i = 0;
                };
                Console.WriteLine(i);
            }
            
            for (int x = 0; x < x + 1; x--) 
            {
                
            }
            Console.ReadLine();
        }
    }
}
