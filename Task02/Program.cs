internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.Write(a);
            Console.Write(" больше ");
            Console.Write(b);
        }
        else
        {
            Console.Write(a);
            Console.Write(" меньше ");
            Console.Write(b);
        }
    }
}