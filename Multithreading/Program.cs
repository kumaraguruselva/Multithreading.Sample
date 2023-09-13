// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Threading;


namespace Multithreadingsample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "MainThread";
            //Console.WriteLine(mainThread.Name);

            CountDown();
            CountUp();
            Console.WriteLine(mainThread.Name + "is Completed!");

            Console.ReadKey();
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine( "Timer #1 : " + i + "seconds" );
                Thread.Sleep(1000);
            }
            Console.WriteLine( "Timer #1 is complete" );
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine( "Timer #2 : " + i + "seconds" );
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete");
        }
    }
}
