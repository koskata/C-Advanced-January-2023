namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            int sum = 0;
            sum = ReadingMatrix(rows, cols, matrix, sum);

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);


        }

        private static int ReadingMatrix(int rows, int cols, int[,] matrix, int sum)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nums[col];
                    sum += nums[col];
                }
            }

            return sum;
        }
    }
}