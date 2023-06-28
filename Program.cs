namespace Deliverable1
{
    internal class Program
    {
        public static void Main()
        {
            int result;
            string odd = "odd";
            string even = "even";
            Console.WriteLine("Please enter a number between 1 and 100");
            string userInput = Console.ReadLine();
            try
            {
                result = Int32.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("Please type 'even' or 'odd'");
            string series = Console.ReadLine();
            series = series.ToLower();

            if (string.Equals(series, even))
            {
                result = Int32.Parse(userInput);
                Console.WriteLine("You selected " + series + " series. The number between 0 and " + result + " are:");
                for (int i = 0; i <=result; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (string.Equals(series, odd))
            {
                result = Int32.Parse(userInput);
                Console.WriteLine("You selected " + series + " series. The number between 1 and " + result + " are:");
                for (int i = 1; i <= result; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("You did not select a correct series");
            }
        }

    }
}