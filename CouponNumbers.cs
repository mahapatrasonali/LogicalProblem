using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class CouponNumbers
    {
       public static void Couponnumber()
        {
            Console.WriteLine("Welcome to a Coupon Number Program");
            Console.WriteLine("Enter the number of Random Coupon's required :");
            int couponLength = Convert.ToInt32(Console.ReadLine());
            int[] totalCoupons = new int[couponLength];
            int randomNum;
            Random random= new Random();
            for (int i = 0; i< totalCoupons.Length; i++) 
            {
            moving:
                randomNum = random.Next();
                for (int x = 0; x < totalCoupons.Length; x++)
                {
                    if (totalCoupons[x] == randomNum)
                    {
                        x--;
                        goto moving;
                    }
                }
                totalCoupons[i] = randomNum;
            
            }
            for(int i =0; i < totalCoupons.Length; i++) 
            {
                Console.WriteLine(totalCoupons[i] + " ");
            }
        }
    }
}
