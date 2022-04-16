using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class CouponNumber
    {
        int count = 0;
        private int i;

        public void Coupon()
        {
            int[] array = new int[10];

            Console.WriteLine("Enter a Number");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int [] array2 = new int[10];
            while (array.Length > 0)
            {
                Random random = new Random();
                int check = random.Next(1);

                if (array[i] == check)
                {
                    array2[i] = check;
                }
                else
                {
                    count++;
                }
                i++;
                }
            Console.WriteLine(count);
            Console.WriteLine(array[i]);
            }
            }
           


        }
   