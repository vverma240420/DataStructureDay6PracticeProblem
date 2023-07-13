namespace DataStructureDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack program");

            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Display();
        }
    }
}