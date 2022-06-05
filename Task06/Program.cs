internal partial class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());
        int m;
        m = n % 2;
        if (m == 0)
        {
            Console.Write(n);
            Console.Write(" явялется четным числом");
        }
        else
        {
            Console.Write(n);
            Console.Write(" является нечетным числом");
        }
    }
}