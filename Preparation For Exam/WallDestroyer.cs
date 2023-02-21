using System;

namespace _02.WallDestroyer
{
    public class WallDestroyer
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int vankoRow = 0;
            int vankoCol = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }

            int count = 1;
            int countRods = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                
                if (command == "up")
                {

                    matrix[vankoRow, vankoCol] = '*';
                    vankoRow--;

                    if (vankoRow < 0 || vankoRow > size)
                    {
                        vankoRow++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        count++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {count} hole(s).");
                        matrix[vankoRow, vankoCol] = 'E';
                        PrintMatrix(size, matrix);
                        return;
                    }
                    else if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        countRods++;
                        Console.WriteLine("Vanko hit a rod!");
                        vankoRow++;
                        
                    }
                    else if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        count++;
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                    else
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                    
                }

                else if (command == "down")
                {
                    matrix[vankoRow, vankoCol] = '*';
                    vankoRow++;
                    if (vankoRow < 0 || vankoRow > size)
                    {
                        vankoRow--;
                        continue;
                    }
                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        count++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {count} hole(s).");
                        matrix[vankoRow, vankoCol] = 'E';
                        PrintMatrix(size, matrix);
                        return;
                    }
                    else if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        countRods++;
                        Console.WriteLine("Vanko hit a rod!");
                        vankoRow--;
                        
                    }
                    else if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        count++;
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                    else
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                }

                else if (command == "right")
                {
                    matrix[vankoRow, vankoCol] = '*';
                    vankoCol++;
                    if (vankoCol < 0 || vankoCol > size)
                    {
                        vankoCol--;
                        continue;
                    }
                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        count++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {count} hole(s).");
                        matrix[vankoRow, vankoCol] = 'E';
                        PrintMatrix(size, matrix);
                        return;
                    }
                    else if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        countRods++;
                        Console.WriteLine("Vanko hit a rod!");
                        vankoCol--;
                        
                    }
                    else if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        count++;
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                    else
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                }

                else if (command == "left")
                {
                    matrix[vankoRow, vankoCol] = '*';
                    vankoCol--;
                    if (vankoCol < 0 || vankoCol > size)
                    {
                        vankoCol++;
                        continue;
                    }
                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        count++;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {count} hole(s).");
                        matrix[vankoRow, vankoCol] = 'E';
                        PrintMatrix(size, matrix);
                        return;
                    }
                    else if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        countRods++;
                        Console.WriteLine("Vanko hit a rod!");
                        vankoCol++;
                        
                    }
                    else if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow, vankoCol] = '*';
                        count++;
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                    else
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                        matrix[vankoRow, vankoCol] = 'V';
                    }
                }
            }

            matrix[vankoRow, vankoCol] = 'V';

            Console.WriteLine($"Vanko managed to make {count} hole(s) and he hit only {countRods} rod(s).");

            PrintMatrix(size, matrix);
        }

        private static void PrintMatrix(int size, char[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
