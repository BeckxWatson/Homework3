using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Please enter sign: ");
            char inputChar = char.Parse(Console.ReadLine());

            if (inputChar == '+' || inputChar == '-')
            {
                Console.Write("Please enter the size of the matrix.: ");
                int matrixSize = int.Parse(Console.ReadLine());

                Console.Write("Please enter the member of the matrix.: ");
                double matrixElement = double.Parse(Console.ReadLine());

                double result = 0;

                if (inputChar == '+')
                {
                    result = matrixSize + matrixElement;
                }
                else if (inputChar == '-')
                {
                    result = matrixSize - matrixElement;
                }

                Console.WriteLine("Total: " + result);
            }
            else
            {
                break;
            }

            Console.WriteLine();
        }
    }
}