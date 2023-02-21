using System.Drawing;

namespace Matrices_Miner_
{
    public class Miner
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int startPositionRow = 0;
            int startPositionCol = 0;
            int coalsCount = 0;
            int endPositionRow = 0;
            int endPositionCol = 0;

            string[,] matrix = new string[size, size];

            string[] commands = Console.ReadLine().Split();

            for (int row = 0; row < size; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == "s")
                    {
                        startPositionRow = row;
                        startPositionCol = col;
                    }
                    if (matrix[row, col] == "c")
                    {
                        coalsCount++;
                    }
                    if (matrix[row, col] == "e")
                    {
                        endPositionRow = row;
                        endPositionCol = col;
                    }
                }
            }

            //ReadingMatrix(size, matrix, startPositionRow, startPositionCol);

            int currRow = startPositionRow;
            int currCol = startPositionCol;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (matrix[currRow - 1, currCol] == "*")
                    {
                        currRow = currRow - 1;
                    }
                    else if (matrix[currRow - 1, currCol] == "c")
                    {
                        matrix[currRow - 1, currCol] = "*";
                        currRow = currRow - 1;
                        
                        coalsCount--;
                        if (coalsCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                            return;
                        }

                    }
                    else if (matrix[currRow - 1, currCol] == "e")
                    {

                        currRow = currRow - 1;
                        Console.WriteLine($"Game over! ({currRow}, {currCol})");
                        return;
                    }
                }
                else if (commands[i] == "down")
                {
                    if (matrix[currRow + 1, currCol] == "*")
                    {
                        currRow = currRow + 1;
                    }
                    else if (matrix[currRow + 1, currCol] == "c")
                    {
                        matrix[currRow + 1, currCol] = "*";
                        currRow = currRow + 1;
                        
                        coalsCount--;
                        if (coalsCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                            return;
                        }
                    }
                    else if (matrix[currRow + 1, currCol] == "e")
                    {

                        currRow = currRow + 1;
                        Console.WriteLine($"Game over! ({currRow}, {currCol})");
                        return;
                    }
                }

                else if (commands[i] == "right")
                {
                    if (currCol + 1 == size)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[currRow, currCol + 1] == "*")
                        {
                            currCol = currCol + 1;
                        }
                        else if (matrix[currRow, currCol + 1] == "c")
                        {
                            matrix[currRow, currCol + 1] = "*";
                            currCol = currCol + 1;
                            
                            coalsCount--;
                            if (coalsCount <= 0)
                            {
                                Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                                return;
                            }
                        }
                        else if (matrix[currRow, currCol + 1] == "e")
                        {

                            currCol = currCol + 1;
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            return;
                        }
                    }
                    
                }

                else if (commands[i] == "left")
                {
                    if (matrix[currRow, currCol - 1] == "*")
                    {
                        currCol = currCol - 1;
                    }
                    else if (matrix[currRow, currCol - 1] == "c")
                    {
                        matrix[currRow, currCol - 1] = "*";
                        currCol = currCol - 1;
                        
                        coalsCount--;
                        if (coalsCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                            return;
                        }
                    }
                    else if (matrix[currRow, currCol - 1] == "e")
                    {

                        currCol = currCol - 1;
                        Console.WriteLine($"Game over! ({currRow}, {currCol})");
                        return;
                    }
                }
                
            }

            Console.WriteLine($"{coalsCount} coals left. ({currRow}, {currCol})");


        }
    }
}