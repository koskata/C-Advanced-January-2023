namespace CustomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            //Console.WriteLine(list.RemoveAt(1));

            Console.WriteLine(list.Contains(3));
            Console.WriteLine(list.Contains(6));

            list.Swap(0, 2);
            list.Swap(1, 3);

            list.Insert(1, 99);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}