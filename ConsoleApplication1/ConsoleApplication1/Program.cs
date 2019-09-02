using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter.Greeting();
            Speaker.SpeakStuff();
            Console.WriteLine("There was a bug on Master branch! this is the bugfix!");
            Console.ReadLine();
        }
    }
}
