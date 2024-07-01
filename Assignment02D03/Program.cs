using System.Numerics;

namespace Assignment02D03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter your number ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            #endregion

            #region Q2
            Console.WriteLine("Enter your number");
            int.TryParse(Console.ReadLine(), out int number2);
            if (number2 > 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("positive");
            #endregion

            #region Q3
            Console.WriteLine("enter three numbers ");
            int.TryParse(Console.ReadLine(), out int number3);
            int.TryParse(Console.ReadLine(), out int number4);
            int.TryParse(Console.ReadLine(), out int number5);

            if (number3 > number4 && number3 > number5)
            {
                Console.WriteLine($"Max is {number3}");
                if (number4 > number5)
                    Console.WriteLine($"Min is :{number5}");
                else
                    Console.WriteLine($"Min is :{number4}");
            }
            else if (number4 > number3 && number4 > number5)
            {
                Console.WriteLine($"Max is {number4}");
                if (number3 > number5)
                    Console.WriteLine($"Min is :{number5}");
                else
                    Console.WriteLine($"Min is :{number3}");
            }
            else if (number5 > number3 && number5 > number4)
            {
                Console.WriteLine($"Max is {number5}");
                if (number3 > number4)
                    Console.WriteLine($"Min is :{number4}");
                else
                    Console.WriteLine($"Min is :{number3}");
            }
            #endregion

            #region Q4
            Console.WriteLine("enter your number ");
            int.TryParse(Console.ReadLine(), out int number6);
            if (number6 % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion

            #region Q5
            Console.WriteLine("enter your char ");
            char.TryParse(Console.ReadLine().ToLower(), out char onechar);
            if (onechar == 'a' || onechar == 'e' || onechar == 'i' || onechar == 'o' || onechar == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("consonant");
            #endregion

            #region Q6
                Console.WriteLine("Enter your number");
                uint.TryParse(Console.ReadLine() , out uint number7);
                for (int i = 1; i <=number7; i++)
                {
                    Console.WriteLine(i);
                }
            #endregion


        }
    }
}
 