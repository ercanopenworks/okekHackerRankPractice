using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            //int[] arr = { 2, 3, 4, 5, 6 };
            int[] arr = { 2, 4, 6,8,10 };

            Console.WriteLine(generalizedGCD(num, arr).ToString());
            Console.ReadKey();

        }

        static int generalizedGCD(int num, int[] arr)
        {
            // WRITE YOUR CODE HERE
            int gcd = 1;
            bool isGCD = false;
                int maxValue = arr.Max();
                for (int j = 2; j <= maxValue; j++)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {

                        if (arr[i] % j == 0)
                        {
                            isGCD = true;
                        }
                        else
                        { 
                            isGCD = false;
                            break;
                        }
                    }

                    if (isGCD)
                    {
                        if (gcd == 1)
                            gcd = j;
                        else
                            if (j < gcd) gcd = j;
                    }


            }

            return gcd;
        }
    }
}
