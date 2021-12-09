using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number
{
    class NumberOperations
    {
        private static int num;
        public static void getInput()
        {
            Console.WriteLine("Input the number:");
            num = int.Parse(Console.ReadLine());
        }

        public static void positive()
        {
            if (num < 0)
                Console.WriteLine(num + " is negative");
            else if (num > 0)
                Console.WriteLine(num + " is positive");
            else
                Console.WriteLine("The number is zero");
        }

        public static void oddeven()
        {
            if (num % 2 == 0)
                Console.WriteLine(num + " is even");
            else
                Console.WriteLine(num + " is odd");
        }
        public static void prime()
        {
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 0)
                Console.WriteLine(num + " is prime");
            else
                Console.WriteLine(num + " is not prime");
        }
          public static void divisible()
        {
            if (num%5==0)
                Console.WriteLine(num + " is divisible by 5");
            else
                Console.WriteLine(num + " is no divisible by 5");
        }
        public static void palindrome()
        {
            int rem = 0;
            int rev = 0;
            int t = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;

            }
            if (t == rev)
                Console.WriteLine(t + " is a palindrome number");
            else
                Console.WriteLine(t + " is not a palindrome number");
        }

    }
}