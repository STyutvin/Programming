internal partial class Program
{
    private static void Main(string[] args)
    {
        //На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.
        Console.WriteLine("Введите рост первого спортсмена в см:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите рост второго спортсмена в см:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите рост третьего спортсмена в см:");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a < b && a < c)
        {
            Console.WriteLine("Вывод результата:");
            Console.WriteLine(a);
            Console.WriteLine(Math.Min(b, c));
            Console.WriteLine(Math.Max(b, c));
        }
        if (b < a && b < c)
        {
            Console.WriteLine("Вывод результата:");
            Console.WriteLine(b);
            Console.WriteLine(Math.Min(a, c));
            Console.WriteLine(Math.Max(a, c));
        }
        if (c < a && c < b)
        {
            Console.WriteLine("Вывод результата:");
            Console.WriteLine(c);
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b));
        }
    }
}