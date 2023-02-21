namespace BlindMansBuff
{
    public class BlindMansBuff
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            int bRow = 0;
            int bCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == "B")
                    {
                        bRow = row;
                        bCol = col;
                    }
                }
            }

            int movesCount = 0;
            int opponentsCount = 0;

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                if (command == "up")
                {
                    matrix[bRow, bCol] = "-";
                    bRow--;
                    if (bRow < 0 || bRow >= rows)
                    {
                        bRow++;
                        matrix[bRow, bCol] = "B";
                        continue;
                    }

                    if (matrix[bRow, bCol] == "P")
                    {
                        movesCount++;
                        matrix[bRow, bCol] = "B";
                        opponentsCount++;
                        if (opponentsCount == 3)
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Touched opponents: {opponentsCount} Moves made: {movesCount}");
                            return;
                        }
                    }
                    else if (matrix[bRow, bCol] == "O")
                    {
                        bRow++;
                        matrix[bRow, bCol] = "B";
                    }
                    else
                    {
                        matrix[bRow, bCol] = "B";
                        movesCount++;
                    }
                }

                else if (command == "down")
                {
                    matrix[bRow, bCol] = "-";
                    bRow++;
                    if (bRow < 0 || bRow >= rows)
                    {
                        bRow--;
                        matrix[bRow, bCol] = "B";
                        continue;
                    }

                    if (matrix[bRow, bCol] == "P")
                    {
                        movesCount++;
                        matrix[bRow, bCol] = "B";
                        opponentsCount++;
                        if (opponentsCount == 3)
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Touched opponents: {opponentsCount} Moves made: {movesCount}");
                            return;
                        }
                    }
                    else if (matrix[bRow, bCol] == "O")
                    {
                        bRow--;
                        matrix[bRow, bCol] = "B";
                    }
                    else
                    {
                        matrix[bRow, bCol] = "B";
                        movesCount++;
                    }
                }

                else if (command == "right")
                {
                    matrix[bRow, bCol] = "-";
                    bCol++;
                    if (bCol < 0 || bCol >= cols)
                    {
                        bCol--;
                        matrix[bRow, bCol] = "B";
                        continue;
                    }

                    if (matrix[bRow, bCol] == "P")
                    {
                        movesCount++;
                        matrix[bRow, bCol] = "B";
                        opponentsCount++;
                        if (opponentsCount == 3)
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Touched opponents: {opponentsCount} Moves made: {movesCount}");
                            return;
                        }
                    }
                    else if (matrix[bRow, bCol] == "O")
                    {
                        bCol--;
                        matrix[bRow, bCol] = "B";
                    }
                    else
                    {
                        matrix[bRow, bCol] = "B";
                        movesCount++;
                    }
                }

                else if (command == "left")
                {
                    matrix[bRow, bCol] = "-";
                    bCol--;
                    if (bCol < 0 || bCol >= cols)
                    {
                        bCol++;
                        matrix[bRow, bCol] = "B";
                        continue;
                    }

                    if (matrix[bRow, bCol] == "P")
                    {
                        movesCount++;
                        matrix[bRow, bCol] = "B";
                        opponentsCount++;
                        if (opponentsCount == 3)
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Touched opponents: {opponentsCount} Moves made: {movesCount}");
                            return;
                        }
                    }
                    else if (matrix[bRow, bCol] == "O")
                    {
                        bCol++;
                        matrix[bRow, bCol] = "B";
                    }
                    else
                    {
                        matrix[bRow, bCol] = "B";
                        movesCount++;
                    }
                }

                //PrintMatrix(rows, cols, matrix);

            }



            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {opponentsCount} Moves made: {movesCount}");



        }






        //private static void PrintMatrix(int rows, int cols, string[,] matrix)
        //{
        //    for (int row = 0; row < rows; row++)
        //    {
        //        for (int col = 0; col < cols; col++)
        //        {
        //            Console.Write(matrix[row, col] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}