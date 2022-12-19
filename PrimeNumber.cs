using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PrimeNumber
    {
        public static void CheckPrime()
        {
            int n, i, m = 0, num = 0;
            Console.WriteLine("Enter The Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++) 
            
            {
               if (n % i ==0)
                {
                    Console.WriteLine("Number is not Prime");
                    num = 1;
                    break;
                }
            }
            if (num == 0) 
            {
                Console.WriteLine("Number is Prime");
            }
        }

    }
}
