using System;

namespace CoreProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the which program to execute");
            Console.WriteLine("1.CouponbNumbers");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Coupon_Numbers.ReadInput();
                    break;
            }
        }
    }
}
