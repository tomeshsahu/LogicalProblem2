using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class PerfectNumber
    {
        int perfect = 0;
        public void Perfect()
        {
            Console.WriteLine("Enter Number for checking Perfect Number");
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= a / 2; i++)
            {
                if(a%i== 0)
                {
                    perfect = perfect + i;
                }
            }
            if(perfect==a)
            {
                Console.WriteLine(a +" is a perfect number"+"\n");
            }
            else
            {
                Console.WriteLine(a +" is a not perfect number"+"\n");
            }
        }
    }
}
