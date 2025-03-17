using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    public class EuropeanTime: ITimePrint
    {
        public override string ToString()
        {
            CultureInfo myCIintl = new CultureInfo("es-ES", false);
            return DateTime.Now.ToString(myCIintl);
        }
        public void Print()
        {
           Console.WriteLine(ToString());
        }
    }
}
