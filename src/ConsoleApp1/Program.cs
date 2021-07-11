using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var t = new Thread(() =>
            {
                List<string> list = new List<string>();
                while (true)
                {
                    list.Add(Allocation());
                    Console.WriteLine("alloc");
                    Thread.Sleep(1000);
                    
                }
            });

            t.Start();
            Console.ReadLine();
        }

        static string Allocation()
        {
            return new string('c', 1024 * 1024 * 10);
        }
    }
}
