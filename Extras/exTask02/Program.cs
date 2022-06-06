internal partial class Program
{
    private static void Main(string[] args)
    {
        //Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.
        Console.WriteLine("Введите число A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B:");
        int b = Convert.ToInt32(Console.ReadLine());
        int c;
        if (a > b)
        {
            Console.WriteLine("Число A должно быть меньше B. Введите число B еще раз:");
            int d = Convert.ToInt32(Console.ReadLine());
            c = d / a;
            Console.WriteLine("Число A содержится в числе B");
            Console.Write(c);
            Console.WriteLine(" раз(а)");
        }
        else
        {
            c = b / a;
            Console.WriteLine("Число A содержится в числе B");
            Console.Write(c);
            Console.WriteLine(" раз(а)");
        }
    }
}