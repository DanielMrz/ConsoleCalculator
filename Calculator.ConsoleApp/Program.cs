using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                // 1. Show headline and app description.
                Console.WriteLine("Hello in calculator application!");

                // 2. Request for first number.
                Console.WriteLine("Enter the first number:");

                // 3. Get number from user.
                var number01 = GetInput();

                // 4. Request for operation.
                Console.WriteLine("What operation do you want to perform? Possible operations: '+', '-', '*', '/'");

                // 5. Get a selected operation form user.
                var operation = Console.ReadLine();

                // 6. Request for second number.
                Console.WriteLine("Enter the second number:");

                // 7. Get number from user.
                var number02 = GetInput();

                // 8. Performing the calculation.
                var result = Calculate(number01, number02, operation);

                // 9. Displaying the result.
                Console.WriteLine($"The result of your operation is: {Math.Round(result, 2)}.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("02: You chose wrong operation!");
            }
        }
    }

    private static double GetInput()
    {
        if (!double.TryParse(Console.ReadLine(), out double input))
            throw new Exception("You chose wrong value");

        return input;
    }

    private static double Calculate(double number01, double number02, string operation)
    {
        switch (operation)
        {
            case "+":
                return number01 + number02;
            case "-":
                return number01 - number02;
            case "*":
                return number01 * number02;
            case "/":
                return number01 / number02;

            default:
                throw new Exception("01: You chose wrong operation!");
        }
    }
}