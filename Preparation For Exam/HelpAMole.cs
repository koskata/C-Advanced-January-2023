using System;

namespace _02.HelpAMole
{
    public class HelpAMole
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int moleRow = 0;
            int moleCol = 0;

            int firstSpecialRow = 0;
            int firstSpecialCol = 0;
            int secondSpecialRow = 0;
            int secondSpecialCol = 0;

            bool isFound = false;

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }

                    if (matrix[row, col] == 'S' && !isFound)
                    {
                        firstSpecialRow = row;
                        firstSpecialCol = col;
                        isFound = true;
                    }
                    if (matrix[row, col] == 'S')
                    {
                        secondSpecialRow = row;
                        secondSpecialCol = col;
                    }
                }
            }


            int points = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    if (points >= 25)
                    {
                        break;
                    }

                    matrix[moleRow, moleCol] = '-';
                    moleRow--;
                    if (moleRow < 0 || moleRow >= size)
                    {
                        moleRow++;
                        Console.WriteLine("Don't try to escape the playing field!");
                        matrix[moleRow, moleCol] = 'M';
                        continue;
                    }



                    if (firstSpecialRow == moleRow && firstSpecialCol == moleCol)
                    {
                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = secondSpecialRow;
                        moleCol = secondSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else if (secondSpecialRow == moleRow && secondSpecialCol == moleCol)
                    {
                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = firstSpecialRow;
                        moleCol = firstSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else
                    {
                        if (char.IsDigit(matrix[moleRow, moleCol]))
                        {

                            points += matrix[moleRow, moleCol] - 48;
                            matrix[moleRow, moleCol] = 'M';
                        }
                        else
                        {
                            matrix[moleRow, moleCol] = 'M';

                        }
                    }
                }

                else if (command == "down")
                {
                    if (points >= 25)
                    {
                        break;
                    }

                    matrix[moleRow, moleCol] = '-';
                    moleRow++;
                    if (moleRow < 0 || moleRow >= size)
                    {
                        moleRow--;
                        Console.WriteLine("Don't try to escape the playing field!");
                        matrix[moleRow, moleCol] = 'M';
                        continue;
                    }



                    if (firstSpecialRow == moleRow && firstSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = secondSpecialRow;
                        moleCol = secondSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else if (secondSpecialRow == moleRow && secondSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = firstSpecialRow;
                        moleCol = firstSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else
                    {
                        if (char.IsDigit(matrix[moleRow, moleCol]))
                        {

                            points += matrix[moleRow, moleCol] - 48;
                            matrix[moleRow, moleCol] = 'M';
                        }
                        else
                        {
                            matrix[moleRow, moleCol] = 'M';

                        }
                    }
                }

                else if (command == "right")
                {

                    if (points >= 25)
                    {
                        break;
                    }

                    matrix[moleRow, moleCol] = '-';
                    moleCol++;
                    if (moleCol < 0 || moleCol >= size)
                    {
                        moleCol--;
                        Console.WriteLine("Don't try to escape the playing field!");
                        matrix[moleRow, moleCol] = 'M';
                        continue;
                    }



                    if (firstSpecialRow == moleRow && firstSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = secondSpecialRow;
                        moleCol = secondSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else if (secondSpecialRow == moleRow && secondSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = firstSpecialRow;
                        moleCol = firstSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else
                    {
                        if (char.IsDigit(matrix[moleRow, moleCol]))
                        {

                            points += matrix[moleRow, moleCol] - 48;
                            matrix[moleRow, moleCol] = 'M';
                        }
                        else
                        {
                            matrix[moleRow, moleCol] = 'M';

                        }
                    }
                }

                else if (command == "left")
                {
                    if (points >= 25)
                    {
                        break;
                    }

                    matrix[moleRow, moleCol] = '-';
                    moleCol--;
                    if (moleCol < 0 || moleCol >= size)
                    {
                        moleCol++;
                        Console.WriteLine("Don't try to escape the playing field!");
                        matrix[moleRow, moleCol] = 'M';
                        continue;
                    }



                    if (firstSpecialRow == moleRow && firstSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = secondSpecialRow;
                        moleCol = secondSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else if (secondSpecialRow == moleRow && secondSpecialCol == moleCol)
                    {

                        points -= 3;
                        matrix[moleRow, moleCol] = '-';
                        moleRow = firstSpecialRow;
                        moleCol = firstSpecialCol;
                        matrix[moleRow, moleCol] = 'M';
                    }
                    else
                    {
                        if (char.IsDigit(matrix[moleRow, moleCol]))
                        {

                            points += matrix[moleRow, moleCol] - 48;
                            matrix[moleRow, moleCol] = 'M';
                        }
                        else
                        {
                            matrix[moleRow, moleCol] = 'M';

                        }
                    }
                }
            }

            matrix[moleRow, moleCol] = 'M';

            if (points < 25)
            {
                Console.WriteLine($"Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }
            else
            {
                Console.WriteLine($"Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
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
