using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProgramming
{
    //Class that implements Find of item T 
    public static class Extension
    {
        public static bool Find<T>(this List<T> couponList,T coupon )
        {
            return couponList.Contains(coupon);
        }
    }
    class Coupon_Numbers
    {
        public static void ReadInput()
        {
            //local variables
            int couponStart,couponEnd;
            List<int> couponList = new List<int>();

            //Get range for coupon from user
            Console.WriteLine("Enter start range of coupon number");
            couponStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End range of coupon number");
            couponEnd = Convert.ToInt32(Console.ReadLine())+1;

            //Function call toGenerate N random coupons
            GenerateCoupon(couponStart,couponEnd, couponList);

        }

        private static void GenerateCoupon(int couponStart,int couponEnd ,List<int> couponList)
        {

            //To create random coupon
            Random random = new Random();
            int coupon,count=0;
            int j=3;
            bool isExist;

            for (int i = 1;couponList.Count < couponEnd-couponStart; i++)
            {
                //Call random function
                coupon=random.Next(couponStart, couponEnd);
                isExist = couponList.Find(coupon);

            //Checks if coupon is in List
                if(isExist!=true)
                {
                    couponList.Add(coupon);
                    Console.WriteLine("Coupon number "+ coupon + " is added \n");
                }

                count++;

            }
            Console.WriteLine(count + " -> No of times random function was run");

        }
    }
}
