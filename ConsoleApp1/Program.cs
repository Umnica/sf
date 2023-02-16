internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        int f(int x = 0)
        {
            return x;
        }
        Console.WriteLine(f());
    }
}

