using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDictionaryPerf
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Random r = new Random();
            Stopwatch s = new Stopwatch();

            int count = 1000 * 1000 *100;
            s.Start();
            for (int i = 0; i < count; i++)
            {
                string rs = r.Next(1000000).ToString();
                int n = 0;
                dict.TryGetValue(rs, out n);
                n++;

                dict[rs] = n;
            }
            s.Stop();

            Console.WriteLine("Insert performance {0} records per sec", count / s.Elapsed.Seconds );
            
        }
    }
}
