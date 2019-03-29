using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tsis6P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] thr = new Thread[3];

            for(int i=0; i<3; i++)
            {
                int local = i;              
                thr[i] = new Thread(new ThreadStart(PrintName));
                thr[i].Name = "Thread #" + local;
            }

            for (int i = 0; i < 3; i++)
            {
                thr[i].Start();
                Thread.Sleep(1000);
            }
             
            void PrintName()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                }
                Console.WriteLine(Thread.CurrentThread.Name + " is over!!!");
            }
        }
    }
}
