internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (a < b) max = b;
        if (b < c) max = c;
        Console.WriteLine("Максимальное число:");
        Console.Write(max);
    }
}