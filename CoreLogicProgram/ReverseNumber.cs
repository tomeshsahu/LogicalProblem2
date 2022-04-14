using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class ReverseNumber
    {
        int reverse = 0;
        int rem = 0;
        public void Reverse()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                rem = a % 10;
                reverse = reverse * 10 + rem;
                a = a / 10;
            }
            Console.WriteLine("Reverse Number= "+reverse + " \n");
        }
    }
}
