namespace _02.NavyBattle
{
    public class NavyBattle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int submarineRow = 0;
            int submarineCol = 0;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'S')
                    {
                        submarineRow = row;
                        submarineCol = col;
                    }
                }
            }

            int health = 3;
            int cruisers = 3;

            while (true)
            {
                if (health == 0)
                {

                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");

                    break;
                }
                if (cruisers == 0)
                {
                    matrix[submarineRow, submarineCol] = 'S';
                    Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                }

                string direction = Console.ReadLine();
                if (direction == "up")
                {
                    submarineRow--;
                    if (matrix[submarineRow, submarineCol] == '*')
                    {
                        health--;
                        matrix[submarineRow + 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else if (matrix[submarineRow, submarineCol] == 'C')
                    {
                        cruisers--;
                        matrix[submarineRow + 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else
                    {
                        
                        matrix[submarineRow + 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                }
                else if (direction == "down")
                {
                    submarineRow++;
                    if (matrix[submarineRow, submarineCol] == '*')
                    {
                        health--;
                        matrix[submarineRow - 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else if (matrix[submarineRow, submarineCol] == 'C')
                    {
                        cruisers--;
                        matrix[submarineRow - 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else
                    {
                        
                        matrix[submarineRow - 1, submarineCol] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                }
                else if (direction == "right")
                {
                    submarineCol++;
                    if (matrix[submarineRow, submarineCol] == '*')
                    {
                        health--;
                        matrix[submarineRow, submarineCol - 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else if (matrix[submarineRow, submarineCol] == 'C')
                    {
                        cruisers--;

                        matrix[submarineRow, submarineCol - 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else
                    {
                        
                        matrix[submarineRow, submarineCol - 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                }
                else if (direction == "left")
                {
                    submarineCol--;
                    if (matrix[submarineRow, submarineCol] == '*')
                    {
                        health--;
                        matrix[submarineRow, submarineCol + 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else if (matrix[submarineRow, submarineCol] == 'C')
                    {
                        cruisers--;
                        matrix[submarineRow, submarineCol + 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                    else
                    {
                        
                        matrix[submarineRow, submarineCol + 1] = '-';
                        matrix[submarineRow, submarineCol] = 'S';
                    }
                }

            }



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