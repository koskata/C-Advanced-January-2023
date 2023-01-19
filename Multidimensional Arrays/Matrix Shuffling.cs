namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandType = cmdArgs[0];
                if (IsValidLength(cmdArgs))
                {
                    continue;
                }
                

                int row1 = int.Parse(cmdArgs[1]);
                int col1 = int.Parse(cmdArgs[2]);
                int row2 = int.Parse(cmdArgs[3]);
                int col2 = int.Parse(cmdArgs[4]);

                if (row1 < 0 || row1 >= rows)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (col1 < 0 || col1 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (row2 < 0 || row2 >= rows)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (col2 < 0 || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                

                SwappingValues(matrix, row1, col1, row2, col2);

                PrintMatrix(rows, cols, matrix);

            }
        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SwappingValues(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string tempValue = matrix[row1, col1];

            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = tempValue;
        }

        private static bool IsValidLength(string[] cmdArgs)
        {
            bool isValid = false;

            if (cmdArgs.Length < 5 || cmdArgs.Length > 5)
            {
                Console.WriteLine("Invalid input!");
                return true;
            }

            return isValid;
            
        }


    }
}