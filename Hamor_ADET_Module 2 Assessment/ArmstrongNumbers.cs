using System;

/** Armstrong Numbers!
    This program determines whether a 
    number is an Armstrong number or not.

    @author: Mary Grizelle Hamor
    @section: BSCS 3-1N
    @date: January 11, 2023
*/

namespace Hamor_ADET_Module_2_Assessment
{
    class ArmstrongNumbers
    {
        private static void Main(string[] args)
        {
            int temp, number, remainder, sum = 0;
     
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\t\tModule 2\n Problem: Identify the Armstrong Numbers");
            Console.WriteLine("------------------------------------------");

            Console.Write("Enter A Number To Check: ");
            temp = int.Parse(Console.ReadLine());

            if (temp >= 0)
            {
                number = temp;

                while (temp > 0)
                {
                    remainder = temp % 10;
                    sum += (remainder * remainder * remainder);
                    temp /= 10;
                }

                string status = (number == sum) ? "An Armstrong Number" : "Not An Armstrong Number";
                Console.WriteLine("\nResult: " + number + " is " + status);

            }
            else
            {
                Console.WriteLine("\nResult: A Negative Number Could Never Be An Armstrong Number");
            }
        }
    }
}