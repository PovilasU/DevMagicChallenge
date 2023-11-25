using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMagicConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "THIS IS TEst striG to test dummy extension";
            //Console.WriteLine("Firts C# program Povilas Test".ToLower());
            String result = str.GetString();
            Console.WriteLine("Dummy results: " + result);
            Console.ReadKey();
        }
    }
}
