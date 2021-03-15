using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
   public class Prisoner
    {



        public int puinshment;
        public int start = 0;
       
        private int inJell ;
        private bool b = new Random().Next(100) % 2 == 0;


        public int InJell
        {
            get
            {
                if (@DateTime.Now.Year - start > puinshment)
                {
                    return inJell=puinshment;
                }
                else if (@DateTime.Now.Year - start < 0)
                {
                    return 0;
                }
                else {
                    return @DateTime.Now.Year - start;
                }
            }
            
        }
        public  bool GetRandomBoolean()
        {
            return b;
        }
        public override string ToString()
        {
            return " \npuinshment: " + puinshment + "\nstart: " + start + "\ninJell: " + InJell + GetRandomBoolean();
        }



    }
   

}
