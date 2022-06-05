internal partial class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        Console.WriteLine("Введите число любое положительное число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int b = 2;
        Console.WriteLine("Вывод результата:");
        if (n >= 2)
        {
            while (b <= n)
            {
                Console.WriteLine(b);
                b = b + 2;
            }
        }
        else
        {
            Console.WriteLine("Количество четных чисел равно 0.");
        }
    }
}