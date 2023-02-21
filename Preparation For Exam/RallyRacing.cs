namespace _02.RallyRacing
{
    public class RallyRacing
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string carNumber = Console.ReadLine();


            int matRow = size;
            int matCol = size;

            string[,] matrix = new string[size, size];


            int firstTunnelRow = 0;
            int firstTunnelCol = 0;
            int secondTunnelRow = 0;
            int secondTunnelCol = 0;

            int endRow = 0;
            int endCol = 0;

            bool isFirst = false;
            

            for (int row = 0; row < size; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    
                    if (matrix[row, col] == "T" && !isFirst)
                    {
                        firstTunnelRow = row;
                        firstTunnelCol = col;
                        isFirst = true;
                    }
                    if (matrix[row, col] == "T")
                    {
                        secondTunnelRow = row;
                        secondTunnelCol = col;
                    }
                    if (matrix[row, col] == "F")
                    {
                        endRow = row;
                        endCol = col;
                    }
                    
                }
            }

            int currRow = 0;
            int currCol = 0;

            int sum = 0;
            bool isFinish = false;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "down")
                {

                    currRow++;

                    if (currRow == firstTunnelRow && currCol == firstTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = secondTunnelRow;
                        currCol = secondTunnelCol;

                        matrix[currRow, currCol] = ".";
                        continue;
                    }
                    if (currRow == secondTunnelRow && currCol == secondTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = firstTunnelRow;
                        currCol = firstTunnelCol;

                        matrix[currRow, currCol] = ".";

                        continue;
                    }

                    sum += 10;

                    if (currRow == endRow && currCol == endCol)
                    {
                        isFinish = true;
                        break;
                    }
                }
                else if (command == "up")
                {
                    currRow--;

                    if (currRow == firstTunnelRow && currCol == firstTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = secondTunnelRow;
                        currCol = secondTunnelCol;

                        matrix[currRow, currCol] = ".";
                        continue;
                    }
                    if (currRow == secondTunnelRow && currCol == secondTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = firstTunnelRow;
                        currCol = firstTunnelCol;

                        matrix[currRow, currCol] = ".";

                        continue;
                    }

                    sum += 10;

                    if (currRow == endRow && currCol == endCol)
                    {
                        isFinish = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    currCol++;

                    if (currRow == firstTunnelRow && currCol == firstTunnelCol)
                    {

                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = secondTunnelRow;
                        currCol = secondTunnelCol;

                        matrix[currRow, currCol] = ".";
                        continue;
                    }
                    if (currRow == secondTunnelRow && currCol == secondTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = firstTunnelRow;
                        currCol = firstTunnelCol;

                        matrix[currRow, currCol] = ".";

                        continue;
                    }

                    sum += 10;

                    if (currRow == endRow && currCol == endCol)
                    {

                        isFinish = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    currCol--;

                    if (currRow == firstTunnelRow && currCol == firstTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = secondTunnelRow;
                        currCol = secondTunnelCol;

                        matrix[currRow, currCol] = ".";

                        continue;
                    }
                    if (currRow == secondTunnelRow && currCol == secondTunnelCol)
                    {
                        sum += 30;

                        matrix[currRow, currCol] = ".";

                        currRow = firstTunnelRow;
                        currCol = firstTunnelCol;

                        matrix[currRow, currCol] = ".";

                        continue;
                    }

                    sum += 10;

                    if (currRow == endRow && currCol == endCol)
                    {

                        isFinish = true;
                        break;
                    }
                }


                //for (int row = 0; row < matrix.GetLength(0); row++)
                //{
                //    for (int col = 0; col < matrix.GetLength(1); col++)
                //    {
                //        Console.Write(matrix[row, col] + " ");
                //    }
                //    Console.WriteLine();
                //}
            }

            matrix[currRow, currCol] = "C";


            if (isFinish)
            {
                Console.WriteLine($"Racing car {carNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {carNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {sum} km.");






            for (int row = 0; row < matRow; row++)
            {
                for (int col = 0; col < matCol; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}