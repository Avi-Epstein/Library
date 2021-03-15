using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
   public static class Court
    {
        public static int thisYear = 2015;
       public static Prisoner[] prisoners = new Prisoner[300];
       public static int count = 0;
        public static void newPrisoner()
        {
            Prisoner x = new Prisoner();
            Prisoner y = new Prisoner();
            for (int i = 0; i< prisoners.Length; i++)
            {
                if (prisoners[i] == null)
                {
                    prisoners[i] = x;
                    prisoners[i + 1] = y;
                    x.start = thisYear;
                    y.start = thisYear;
                    break;
                }
            }
            Judge.judgment(x, y);
            count++;
            countPlus();


        }
            static void countPlus()
            {
                if (count % 20 == 0)
                {
                    thisYear++;
                }
            }
       

    }
}
