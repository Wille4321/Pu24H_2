using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D; // 3.3333
            CultureInfo enUs = new CultureInfo("en-Us");

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-10$ / 3$ = {0:0:00}$", money));
            Console.WriteLine(money.ToString("C", enUs));
            Console.WriteLine(money.ToString("C0", enUs));
            Console.WriteLine(money.ToString("C1", enUs));
            Console.WriteLine(money.ToString("C2", enUs));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));

            Console.ReadLine();
        }
    }
}
