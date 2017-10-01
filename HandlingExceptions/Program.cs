using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"F:\CodingTestExample.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

            }
            Console.ReadLine();
        }
    }
}