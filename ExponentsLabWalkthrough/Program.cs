public class Program
{

    public static void Main()
    {
        bool goAgain = true;
        bool invalidNum = false;
        while (goAgain == true)
        {
            Console.WriteLine("Hello welcome to the exponent finder ");
            string input = GetUserInput("Please input a number so we can create our exponent table");


            int num = int.Parse(input);
            if (num > 0 && num <= 1290)
            {
                

                for (int i = 1; i <= num; i++)
                {
                    PrintExponent(i);
                }
            }
            else
            {
                invalidNum = true;
                Console.WriteLine("That number was outside of the range of 1 to 1290");
                Console.WriteLine("Lets try that again");
                continue;
                //Continue skips to the next run of the loop
            }

        }
        goAgain = RunAgain();
    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }
    public static void PrintExponent(int n)
    {
        Console.WriteLine($"Base: {n}");
        Console.WriteLine($"Square: {n * n}");
        Console.WriteLine($"Cubed: {n * n * n}");  
        Console.WriteLine();
    }
    public static bool RunAgain()
    {
        Console.WriteLine("would you like to see another exponent table");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("I'm sorry I didn't understand that");
            Console.WriteLine("Please input y or n");
            Console.WriteLine("Lets try again");
            return RunAgain();

        }
    }        
}
