using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogicProgram
{

    public class Temprature
    {
        double F = 0;  double C;
        public void Conversion(int a,int b) {
            F=(a * 9 / 5) + 32 ;
            Console.WriteLine("Fahrenheit" + " " + F);
            C =(b - 32) * 5 / 9;
            Console.WriteLine("Celcius"+" "+C);
        }
    }
}

