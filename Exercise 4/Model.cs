using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Model
    {
        public double x= 0, y =0;

        public double Add(string T1, string T2)
        {
            Check(T1,T2);



            return x + y;

        }
        public double Sub(string T1, string T2)
        {

            Check(T1, T2);

            return x - y;

        }
        public double Mul(string T1, string T2)
        {

            Check(T1, T2);

            return x * y;

        }
        public double Div(string T1, string T2)
        {
            Check(T1, T2);
            if (y == 0)
            {
                return 0;
            }
            else


                return x / y;

        }
        void Check(string first, string second)
        {
            double.TryParse(first, out x);
            double.TryParse(second, out y);
        }
    }

}
