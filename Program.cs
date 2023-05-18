using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter '+' or '-' to perform matrix operations, or any other character to exit.");
            Console.Write("Operator: ");
            char operatorChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operatorChar == '+' || operatorChar == '-')
            {
                Console.Write("Enter the size of the matrix (positive integer): ");
                int size = ReadPositiveInteger();

                Console.Write("Enter the value for the matrix elements (real number): ");
                double value = ReadRealNumber();

                if (operatorChar == '+')
                {
                    double result = size + value;
                    Console.WriteLine("Result: " + result);
                }
                else if (operatorChar == '-')
                {
                    double result = size - value;
                    Console.WriteLine("Result: " + result);
                }
            }
            else
            {
                Console.WriteLine("Exiting the program.");
                continueProgram = false;
            }

            Console.WriteLine();
        }
    }

    static int ReadPositiveInteger()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }
        return value;
    }

    static double ReadRealNumber()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Please enter a real number: ");
        }
        return value;
    }
}

