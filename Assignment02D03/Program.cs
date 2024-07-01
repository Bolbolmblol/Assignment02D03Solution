using System.Numerics;

namespace Assignment02D03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.*/
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
            /*Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.*/
            Console.WriteLine("Enter your number");
            int.TryParse(Console.ReadLine(), out int number2);
            if (number2 > 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("positive");
            #endregion

            #region Q3
            /*Write a program that takes 3 integers from the user then prints the max element and the min element.*/
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
            /*Write a program that allows the user to insert an integer number then check If a number is even or odd.*/
            Console.WriteLine("enter your number ");
            int.TryParse(Console.ReadLine(), out int number6);
            if (number6 % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion

            #region Q5
            /*Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/
            Console.WriteLine("enter your char ");
            char.TryParse(Console.ReadLine().ToLower(), out char onechar);
            if (onechar == 'a' || onechar == 'e' || onechar == 'i' || onechar == 'o' || onechar == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("consonant");
            #endregion

            #region Q6
            /*Write a program that allows the user to insert an integer then print all numbers between 1 to that number.*/
            Console.WriteLine("Enter your number");
                uint.TryParse(Console.ReadLine() , out uint number7);
                for (int i = 1; i <=number7; i++)
                {
                    Console.WriteLine(i);
                }
            #endregion

            #region Q7
            /*Write a program that allows the user to insert an integer then 
            print a multiplication table up to 12.*/
            Console.WriteLine("Enter your number");
            int.TryParse(Console.ReadLine() , out int number8);
            for(int i = 1;i<=12;i++)
            {
                Console.WriteLine($"{number8}*{i}={number8*i}");
            }
            #endregion
        }
}
}
