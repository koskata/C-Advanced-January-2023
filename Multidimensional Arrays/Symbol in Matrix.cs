using System.Runtime.CompilerServices;

namespace _04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string text = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    char ch = (char)text[col];

                    matrix[row, col] = ch;

                }
            }

            char symbol = char.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (symbol == matrix[i, j])
                    {
                        isFound = true;

                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
                
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}