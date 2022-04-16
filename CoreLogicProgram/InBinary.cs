using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class InBinary
    {
        public void Binary()
        {
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                int S = num % 2;
                {
                    
                    Console.WriteLine(S);

                }
                num = num / 2;
            }
            
        }
    }
}
