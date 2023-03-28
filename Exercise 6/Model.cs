using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Model
    {
        int i  = 0;
        public string Add()
        {
            i++;
            return string.Format("=" + i);
        }
        public string Remove()
        {
            i = 0;
            return string.Format("");
        }
    }
}
