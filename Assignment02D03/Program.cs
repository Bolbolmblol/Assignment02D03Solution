using System.Numerics;
using System.Reflection.Metadata.Ecma335;

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

            #region Q8
            /*Write a program that allows to user to insert number then print all even numbers between 1 to this number*/
            Console.WriteLine("ENTER YOR NUMBER");
            int.TryParse(Console.ReadLine() , out int number9);
            for (int i = 1; i <= number9; i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
            #endregion

            #region Q9
            /*Write a program that takes two integers then prints the power*/
            Console.WriteLine("enter number");
            int.TryParse(Console.ReadLine(), out int number10);
            Console.WriteLine("enter power");
            int.TryParse (Console.ReadLine() , out int power);
            int equal = 1;
            for (int i = 1;i<=power;i++)
            {
                equal *= number10;
            }
            Console.WriteLine(equal);
            #endregion

            #region Q10
            /*Write a program to enter marks of five subjects and calculate total, average and percentage.*/
            Console.WriteLine("enter  your five degrees");
            int.TryParse(Console.ReadLine(),out int degree1);
            int.TryParse(Console.ReadLine(), out int degree2);
            int.TryParse(Console.ReadLine(), out int degree3);
            int.TryParse(Console.ReadLine(), out int degree4);
            int.TryParse(Console.ReadLine(), out int degree5);
            int sum=degree1 + degree2+ degree3+degree4+degree5;
            int average=sum/5;
            int precentage = sum / 500 * 100;
            Console.WriteLine($"sum is :  {sum} , average is : {average}  , precentage is:  {precentage}");

            #endregion

            #region Q11
            /*Write a program to input the month number and print the number of days in that month.*/
            Console.WriteLine("enter number month ");
            int.TryParse(Console.ReadLine(), out int month);
            switch(month)
            { 
                case 1:
                case 3:
                case 5: 
                case 7:
                case 9:
                case 10:
                case 12:
                    Console.WriteLine("days is 31");
                    break;
                case 2:
                    Console.WriteLine("days is 29");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("days is 30");
                    break;
                default:
                    Console.WriteLine("out of range");
                    break;
            }

            #endregion

            #region Q12
            /*12- Write a program to create a Simple Calculator.*/
            Console.WriteLine("enter two numbers ");
            double.TryParse(Console.ReadLine(), out double calcu1);
            double.TryParse(Console.ReadLine(), out double calcu2);
            Console.WriteLine("enter your operator 1=+ 2=- 3= * 4 = /");
            int.TryParse(Console.ReadLine(), out int operat);
            switch(operat)
            {
                case 1:
                    Console.WriteLine($"sum is {calcu1+calcu2}");
                    break;
                case 2:
                    Console.WriteLine($"intersect is {calcu1 - calcu2}");
                    break;
                case 3:
                    Console.WriteLine($"multi is {calcu1 * calcu2}");
                    break;
                case 4:
                    if (number2 != 0)
                        Console.WriteLine($"divide is {calcu1 / calcu2}");
                    else
                        Console.WriteLine("cnnot divide by 0");

                    break;
                default:
                    Console.WriteLine("out of range ");
                    break;
            }


            #endregion
        }
    }
}
