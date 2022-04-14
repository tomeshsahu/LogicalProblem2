using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{
    public class Fibonacci
    {
        int a = 0, b = 1, s = 0;
        public void Fibonnac()
        {
            Console.WriteLine("Enter Number for Series");
            int l=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <l; i++)
            {
                s = a + b;
                Console.WriteLine(s);
                a = b;
                b = s;

            }
        }
        public static void main(String[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.Fibonnac();
        }
        
    }
}
