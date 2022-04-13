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
            PrimeNumber prime = new PrimeNumber();
            prime.Prime();
            break;


        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

    }
}