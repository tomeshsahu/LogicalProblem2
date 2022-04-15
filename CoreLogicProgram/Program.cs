using System;
using CoreLogicProgram;

Console.WriteLine("Welcome to Basic Program");
bool check = true;
while(check)
{ 

    Console.WriteLine("1.Factorial\n2.Perfect Number\n3.primeNumber\n4.Reverse Number\n5.Fibonacci\n6.Temprature Conversion\n7.DayOfWeak");
    Console.WriteLine("Please Enter the Number Which program you want to run");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            RFactor Obj = new RFactor();
            Obj.Factorial();
            break;

        case 2:
            PerfectNumber Perfect = new PerfectNumber();
            Perfect.Perfect();
            break;

        case 3:
            PrimeNumber prime = new PrimeNumber();
            prime.Prime();
            break;

        case 4:
            ReverseNumber Reverse = new ReverseNumber();
            Reverse.Reverse();
            break;
        case 5:
            Fibonacci Series = new Fibonacci();
            Series.Fibonnac();
            break;
        case 6:
            Temprature conv = new Temprature();
            conv.Conversion(15,65);
            break;
        case 7:
            DayOfWeak day = new DayOfWeak();
            day.DOW(1, 1, 2016);
            day.MOY(8, 8, 2016);
            break;
        case 0:
            check = false;
            break;
        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

    }
}