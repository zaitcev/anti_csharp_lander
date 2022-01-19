// My first C# program - "Moon Lander"

using System;
using System.IO;   // StreamReader

namespace lander
{
    class Program
    {
        // We create a dedicated constant right away because:
        //    1. Mission calculations need this as well as mission clock.
        //    2. We are likely to change it if we make this real time.
        // In gaming terms this is the inverse of FPS.
        public const double Tick = 1.0;  // In seconds

        static void Main(string[] args)
        {
            StreamReader inp;
            StreamWriter outp;
            string line;

            // Let's use double because a literal without a suffix is a double.
            double thrust = 0.0;
            double altitude = 100.0;   // In meters for now

            double clock = 0.0;        // Mission clock

            inp = new StreamReader(Console.OpenStandardInput());
            outp = new StreamWriter(Console.OpenStandardOutput());
            outp.AutoFlush = true;
            // Console.WriteLine("Lander");
            outp.WriteLine("*** LANDER ***");

            outp.Write("> ");
            while ((line = inp.ReadLine()) != null) {

                if (line.Length == 0) {
                    // Should we re-display the mission status on empty input?
                    // Or maybe advance the mission clock with existing thrust?
                    outp.Write("> ");
                    continue;
                }

                // I saw tutorials that use Convert.ToInt32(val);
                // Maybe coming from System.Collections.Generic;
                // Not sure which one is better.
                try {
                    thrust = double.Parse(line);
                } catch (System.FormatException) {
                    // Note that we error to console output rather than error.
                    // outp.WriteLine(e.Message);
                    outp.WriteLine("Invalid number: ", line);

                    outp.Write("> ");
                    continue;
                }

                outp.WriteLine(" clock {0} alt {1} thr {2}",
                               clock, altitude, thrust);

                clock += Tick;      // Emulate at 1 second intervals
                outp.Write("> ");
            }
        }
    }
}
