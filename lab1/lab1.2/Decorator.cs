using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    public class Decorator: ITimePrint
    {
        protected ITimePrint timeprint;
        public Decorator(ITimePrint timeprint)
        {
            this.timeprint = timeprint;
        }

        public void Print() { 
            Console.WriteLine(ToString());
        }
    }
}
