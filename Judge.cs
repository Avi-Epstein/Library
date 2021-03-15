using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
     static class Judge
    {
        public static void judgment(Prisoner x, Prisoner y)
        {
            if (x.GetRandomBoolean() && y.GetRandomBoolean())
            {
                x.puinshment = 3;
                y.puinshment = 3;
            }
            else if (x.GetRandomBoolean() && !y.GetRandomBoolean())
            {
                x.puinshment = 1;
                y.puinshment = 10;
            }
            else if (!x.GetRandomBoolean() && y.GetRandomBoolean())
            {
                x.puinshment = 10;
                y.puinshment = 1;

            }
            else 
            {
                x.puinshment = 7;
                y.puinshment = 7;
            }
        }
    }
    

}
