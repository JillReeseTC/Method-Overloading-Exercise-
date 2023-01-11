using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int var = 1;
            int var0 = 0;
            int var1 = 2;
            int var2 = 3;
            int var3 = 4;
            int var4 = 6;
            decimal var5 = 7.0m;
            decimal var6 = 12.4m;


            Add(var1, var2);
            Add(var5, var6);
            Console.WriteLine(Add(var3, var4, false));
            Console.WriteLine(Add(var3, var4, true));
            Console.WriteLine(Add(var, var0, true));
        }

        public static void Add(int num, int num2)
        {
            int sum = num + num2;
            Console.WriteLine($"The sum of {num} and {num2} is {sum}.");
        }

        public static void Add(decimal number, decimal number2)
        {
            decimal sum2 = number + number2;
            Console.WriteLine($"The sum of {number} and {number2} is {sum2}.");
        }
        public static string Add(int num3, int num4, bool isDollar)
        {
            int sum3 = num3 + num4;

            if ( isDollar )
            {
                if (sum3 == 1)
                {
                    return $"{sum3} dollar";
                }
                else
                {
                    return $"{sum3} dollars";
                }
            }
            else
            {
                return $"The sum of {num3} and {num4} is {sum3}.";
            }
            
        }
    }
}
