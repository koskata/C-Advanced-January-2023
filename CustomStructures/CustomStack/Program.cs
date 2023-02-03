namespace CustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ForEach(x => Console.WriteLine(x + " "));

            //stack.Pop();
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());
        }

        
    }
}