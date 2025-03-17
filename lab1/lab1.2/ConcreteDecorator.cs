using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    public class ConcreteDecorator: Decorator
    {
        protected string str;
        public ConcreteDecorator(ITimePrint timeprint, string add): base(timeprint)
        {
            str = add;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(timeprint.ToString());
            sb.Append(str);
            return sb.ToString();
        }
        
    }
}
