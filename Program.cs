using System;

namespace homeWork3
{
  public  class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i< 150; i++)
            {
                Court.newPrisoner();
            }
           
            for (int i=0; i < 300; i++)
            {
                Console.WriteLine(Court.prisoners[new Random().Next(0,300)]);
            }
           

        }

        
    }
}
