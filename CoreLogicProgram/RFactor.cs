using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class RFactor
    {
        int Fact=1;
        public void Factorial()
        {
            Console.WriteLine("Enter Number for Factorial");
            int a=Convert.ToInt32(Console.ReadLine());

            for(int i = a; i > 0; i--)
            {
                Fact = Fact * i;
                
            }
            Console.WriteLine("Factorial is " + Fact);
        }


        

     
    }
}
