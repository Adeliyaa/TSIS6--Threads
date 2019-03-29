using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = {
            new Thread ( new ThreadStart(Func) ),
            new Thread ( new ThreadStart(Func) ),
            new Thread ( new ThreadStart(Func) )
            };

            threads[0].Name = "Thread-1";
            threads[1].Name = "Thread-2";
            threads[2].Name = "Thread-3";


            threads[0].Start();
            threads[1].Start();
            threads[2].Start();
            Thread.Sleep(3000);
        }

        static void Func()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);

            }
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");
        }


    }
}