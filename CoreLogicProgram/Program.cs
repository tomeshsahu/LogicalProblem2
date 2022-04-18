using System;
using CoreLogicProgram;

Console.WriteLine("Welcome to Basic Program");
bool check = true;
while(check)
{ 

    Console.WriteLine("1.Factorial\n2.Perfect Number\n3.primeNumber\n4.Reverse Number\n5.Fibonacci\n6.Temprature Conversion\n7.DayOfWeak\n8.In-Binary\n9.Vending Machine\n10.Coupon Number\n11.Monthly Payment\n12.Square Root");
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
        case 8:
            InBinary binary = new InBinary();
            binary.CalToBinary(6);
            break;
        case 9:
            VendingMachine Machine = new VendingMachine();
            Machine.Vending();
            break;
        case 10:
            CouponNumber coupon = new CouponNumber();
            coupon.Coupon();
            break;
        case 11:
            MonthlyPayment Payment = new MonthlyPayment();
            Payment.CalMonthlyPayment(90000,5000,5);
            break;
        case 12:
            SquareRoot Square = new SquareRoot();
            Square.Root();
            break;
        case 0:
            check = false;
            break;
        default:
            Console.WriteLine("Please Enter Valid Number");
            break;

    }
}