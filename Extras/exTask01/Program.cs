internal class Program
{
    private static void Main(string[] args)
    {
        //Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        Console.WriteLine("Вывод результата:");
        while (i < n)
        {
            Console.Write("1");
            i = i + 1;
        }
    }
}