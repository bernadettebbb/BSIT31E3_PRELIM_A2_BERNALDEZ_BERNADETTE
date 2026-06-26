while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    double firstNumber = Convert.ToDouble(input);

    Console.Write("Enter second number (or 'exit' to quit): ");
    input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    double secondNumber = Convert.ToDouble(input);

    Console.Write("Enter an operation (+, -, *, /): ");
    string operation = Console.ReadLine();

    double result = 0;
    bool validOperation = true;

    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;

        case "-":
            result = firstNumber - secondNumber;
            break;

        case "*":
            result = firstNumber * secondNumber;
            break;

        case "/":
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                validOperation = false;
            }
            break;

        default:
            Console.WriteLine("Error: Invalid operation.");
            validOperation = false;
            break;
    }

    if (validOperation)
    {
        Console.WriteLine($"Result: {result}");
    }
}