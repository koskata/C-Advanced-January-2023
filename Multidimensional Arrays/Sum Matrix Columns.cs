namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }

            //PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}