Console.WriteLine("Hello, Welcome to the calculator application");

// Get first number with validation
Console.WriteLine("Please input the first number");
var firstNumber = Console.ReadLine();
if (!int.TryParse(firstNumber, out int number1))
{
    Console.WriteLine("Invalid number entered. Exiting.");
    return;
}

// Get second number with validation
Console.WriteLine("Please input the second number");
var secondNumber = Console.ReadLine();
if (!int.TryParse(secondNumber, out int number2))
{
    Console.WriteLine("Invalid number entered. Exiting.");
    return;
}

// Get the operation from the user
Console.WriteLine("Please input the operation you want to perform");
Console.WriteLine("[A]ddition");
Console.WriteLine("[S]ubtraction");
Console.WriteLine("[M]ultiplication");
Console.WriteLine("[D]ivision");
Console.WriteLine("[E]xit from the application");
var operation = Console.ReadLine()?.ToUpper(); // Make input case-insensitive

// Perform the operation
if (operation == "A")
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (operation == "S")
{
    var difference = number1 - number2;
    PrintFinalEquation(number1, number2, difference, "-");
}
else if (operation == "M")
{
    var product = number1 * number2;
    PrintFinalEquation(number1, number2, product, "*");
}
else if (operation == "D")
{
    // Check for division by zero
    if (number2 == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        var quotient = number1 / number2;
        PrintFinalEquation(number1, number2, quotient, "/");
    }
}
else if (operation == "E")
{
    Console.WriteLine("Exiting from the application");
}
else
{
    Console.WriteLine("Invalid operation selected. Please enter the correct choice.");
}

// Method to print the final equation
void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine($"{number1} {@operator} {number2} = {result}");
}

Console.WriteLine("Thank you for using the calculator application.");
Console.ReadKey();
