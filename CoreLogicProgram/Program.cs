using System;
using CoreLogicProgram;

<<<<<<< Updated upstream
class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Basic Program");
        while (true)
        {
            Console.WriteLine("1.Fibonacci\n2.Perfect Number\n3.primeNumber\n4.Reverse Number");
            Console.WriteLine("Please Enter the Number Which program you want to run");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fibonnac();
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
                    ReverseNumber Reverse = new ReverseNumber();
                    Reverse.Reverse();
                    break;
=======
Console.WriteLine("Welcome to Basic Program");
bool end = true;
while (end==true)
{
    Console.WriteLine("1.Factorial\n2.Perfect Number\n3.primeNumber\n4.Reverse Number\n5.Temprature");
    Console.WriteLine("Please Enter the Number Which program you want to run");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            RFactor Obj = new RFactor();
            Obj.Factorial();
            break;
        case 2:
            PerfectNumber perfect = new PerfectNumber();
            perfect.Perfect();
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
            Temprature Conv = new Temprature();
            Conv.Conversion(6,55);
            break;
>>>>>>> Stashed changes

        case 0:
            end = false;
            break;

<<<<<<< Updated upstream
                default:
                    Console.WriteLine("Please Enter Valid Option" + "\n");
                    break;

            }
        }
=======
        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

>>>>>>> Stashed changes
    }
}