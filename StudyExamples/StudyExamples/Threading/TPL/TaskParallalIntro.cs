using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExamples
{
    class TaskParallalIntro
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, PrintSquare);
            Console.ReadKey();
            
            //using inline function
            Parallel.For(0, 10, x =>
                {
                    Console.WriteLine("value of i = {0}", x);
                });
            Console.ReadKey();
           

            //sample code for action delegate with single argument with no return type. passing entire function pointer to method
            GetData(0, 20, x => { Console.Write("hello world"); Console.WriteLine("value of x = {0}", x); });
            Console.ReadKey();
        }

      

        static void PrintSquare(int value)
        {
            Console.WriteLine("Square of {0} is {1}", value, value * value);
        }

        //passing single argument delegate to this function
        static void GetData(int min, int max, Action<int> mydelefun)
        {
            for (int i = min; i < max; i++)
            {
                mydelefun(i);
            }
        }
    }
}
