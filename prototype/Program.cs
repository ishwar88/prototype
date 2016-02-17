using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int closeVal = 4;
            int arrayVal = 0;

            string stockInfoGSPC = File.ReadAllText(@"C:\S-P\^GSPC.TXT");
            var stockArrayGSPC = stockInfoGSPC.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

            float[] GSPC = new float[(stockArrayGSPC.Length+1)/6];

            for (int i = 0; i < (stockArrayGSPC.Length)/6; i++)
            {
                GSPC[arrayVal] = Convert.ToSingle(stockArrayGSPC[closeVal]);
                closeVal += 6;
                ++arrayVal;
            }

            for (int i = 0; i < GSPC.Length; i++)
            {
                Console.WriteLine(GSPC[i]);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}