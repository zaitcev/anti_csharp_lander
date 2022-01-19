// My first C# program - "Moon Lander"

using System;
using System.IO;   // StreamReader

namespace lander
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inp;
            StreamWriter outp;
            string line;

            inp = new StreamReader(Console.OpenStandardInput());
            outp = new StreamWriter(Console.OpenStandardOutput());
            outp.AutoFlush = true;
            // Console.WriteLine("Lander");
            outp.WriteLine("Lander");
            while ((line = inp.ReadLine()) != null) {
                outp.WriteLine(line);
            }
        }
    }
}
