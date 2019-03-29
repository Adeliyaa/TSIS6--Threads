using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tsis6P2
{
    class Program
    {
        class MyThread
        {

            Thread threadField;// = new Thread(startThread);

            public MyThread(string name)
            {
               threadField = new Thread(startThread);
               threadField.Name = name;            
            }

            public void startThread()
            {               
               for (int i=1; i<5; i++)
                {
                    Console.WriteLine(threadField.Name + " " + i);
                    //Console.WriteLine(Thread.CurrentThread.Name);
                }
                Console.WriteLine(threadField.Name + "is over!!!");                
            }
        }
            


        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");

            t1.startThread();
            t2.startThread();
            t3.startThread();
        }
    }
}
