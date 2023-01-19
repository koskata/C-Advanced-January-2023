namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[allSize, allSize];

            for (int row = 0; row < allSize; row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < allSize; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }


            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}