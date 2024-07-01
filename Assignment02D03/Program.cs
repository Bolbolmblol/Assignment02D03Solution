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
            uint.TryParse(Console.ReadLine(), out uint number7);
            for (int i = 1; i <= number7; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Q7
            /*Write a program that allows the user to insert an integer then 
            print a multiplication table up to 12.*/
            Console.WriteLine("Enter your number");
            int.TryParse(Console.ReadLine(), out int number8);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number8}*{i}={number8 * i}");
            }
            #endregion

            #region Q8
            /*Write a program that allows to user to insert number then print all even numbers between 1 to this number*/
            Console.WriteLine("ENTER YOR NUMBER");
            int.TryParse(Console.ReadLine(), out int number9);
            for (int i = 1; i <= number9; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            #endregion

            #region Q9
            /*Write a program that takes two integers then prints the power*/
            Console.WriteLine("enter number");
            int.TryParse(Console.ReadLine(), out int number10);
            Console.WriteLine("enter power");
            int.TryParse(Console.ReadLine(), out int power);
            int equal = 1;
            for (int i = 1; i <= power; i++)
            {
                equal *= number10;
            }
            Console.WriteLine(equal);
            #endregion

            #region Q10
            /*Write a program to enter marks of five subjects and calculate total, average and percentage.*/
            Console.WriteLine("enter  your five degrees");
            int.TryParse(Console.ReadLine(), out int degree1);
            int.TryParse(Console.ReadLine(), out int degree2);
            int.TryParse(Console.ReadLine(), out int degree3);
            int.TryParse(Console.ReadLine(), out int degree4);
            int.TryParse(Console.ReadLine(), out int degree5);
            int sum = degree1 + degree2 + degree3 + degree4 + degree5;
            int average = sum / 5;
            int precentage = sum / 500 * 100;
            Console.WriteLine($"sum is :  {sum} , average is : {average}  , precentage is:  {precentage}");

            #endregion

            #region Q11
            /*Write a program to input the month number and print the number of days in that month.*/
            Console.WriteLine("enter number month ");
            int.TryParse(Console.ReadLine(), out int month);
            switch (month)
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
            switch (operat)
            {
                case 1:
                    Console.WriteLine($"sum is {calcu1 + calcu2}");
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

            #region Q13
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string reversedString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }
            Console.WriteLine("Reversed string: " + reversedString);
            #endregion

            #region Q14
            /*14- Write a program to allow the user to enter int and print the REVERSED of it.*/
            Console.WriteLine("Enter an integer: ");
            string input2 = Console.ReadLine();
            if (int.TryParse(input, out int number12))
            {
                string reversedString2 = "";
                for (int i = input2.Length - 1; i >= 0; i--)
                {
                    reversedString2 += input[i];
                }
                int reversedNumber2 = int.Parse(reversedString2);

                #endregion

            #region Q15
                /*Write a program in C# Sharp to find prime numbers within a range of numbers.*/
                // Prompt the user to enter the range
                Console.WriteLine("Enter the starting number of the range: ");
                int start = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the ending number of the range: ");
                int end = int.Parse(Console.ReadLine());

                Console.WriteLine($"Prime numbers between {start} and {end} are:");

                for (int num = start; num <= end; num++)
                {
                    if (num <= 1)
                    {
                        continue; 
                    }

                    bool isPrime = true;

                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(num);
                    }
                }
                #endregion

            #region Q16
                /*. Write a program in C# Sharp to convert a decimal number into binary without using an array.*/
                Console.WriteLine("Enter a decimal number: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                string binaryString = "";

                if (decimalNumber == 0)
                {
                    binaryString = "0";
                }
                else
                {
                    while (decimalNumber > 0)
                    {
                        int remainder = decimalNumber % 2;
                        binaryString = remainder + binaryString;
                        decimalNumber /= 2;
                    }
                }

                Console.WriteLine("Binary representation: " + binaryString);
                #endregion

            #region Q17
                Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
                Console.Write("x1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("y1: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
                Console.Write("x2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("y2: ");
                double y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of the third point (x3, y3): ");
                Console.Write("x3: ");
                double x3 = double.Parse(Console.ReadLine());
                Console.Write("y3: ");
                double y3 = double.Parse(Console.ReadLine());

                double slope1 = (y2 - y1) * (x3 - x2);
                double slope2 = (y3 - y2) * (x2 - x1);

                if (slope1 == slope2)
                {
                    Console.WriteLine("The points lie on a single straight line.");
                }
                else
                {
                    Console.WriteLine("The points do not lie on a single straight line.");
                }
                #endregion

            #region Q18
                /*Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                    - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                    - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                    - If the worker takes more than 5 hours, they are required to leave the company. 
                    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

                */
                Console.WriteLine("Enter the time taken to complete the task (in hours): ");
                double timeTaken = double.Parse(Console.ReadLine());

                int timeCategory = (int)Math.Ceiling(timeTaken);

                switch (timeCategory)
                {
                    case 2:
                    case 3:
                        Console.WriteLine("The worker is highly efficient.");
                        break;
                    case 4:
                        Console.WriteLine("The worker needs to increase their speed.");
                        break;
                    case 5:
                        Console.WriteLine("The worker needs training to improve their speed.");
                        break;
                    default:
                        if (timeTaken > 5)
                        {
                            Console.WriteLine("The worker has to leave the company.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Time must be at least 2 hours.");
                        }
                        break;
                }
                #endregion
            }
        }
    }
}
