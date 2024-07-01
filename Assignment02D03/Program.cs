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

        }
    }
}
