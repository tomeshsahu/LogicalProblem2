using System;
using CoreLogicProgram;

Console.WriteLine("Welcome to Basic Program");
while (true)
{
    Console.WriteLine("1.Factorial\n2.Perfect Number\n3.primeNumber\n4.Reverse Number");
    Console.WriteLine("Please Enter the Number Which program you want to run");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            RFactor Obj = new RFactor();
            Obj.Factorial();
            break;
        case 2:
            PerfectNumber Per = new PerfectNumber();
            Per.Perfect();
            break;

        case 3:
            PrimeNumber prime = new PrimeNumber();
            prime.Prime();
            break;

        case 4:
            ReverseNumber  Reverse = new  ReverseNumber();
            Reverse.Reverse();
            break;

        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

    }
}