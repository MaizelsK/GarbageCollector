using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework
            User user = new User { Login = "wasd", Password = "123" };

            Console.WriteLine("До изменения поколения: {0}", GC.GetGeneration(user));

            GC.Collect(GC.GetGeneration(user));

            Console.WriteLine("После: {0}", GC.GetGeneration(user));
        }
    }
}
