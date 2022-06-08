internal partial class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (a < b) max = b;
        if (max < c) max = c;
        Console.Write("Максимальное число: ");
        Console.Write(max);
    }
}