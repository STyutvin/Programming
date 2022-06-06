// Дано N секунд. Вывести время в формате часы:минуты:секунды.
Console.WriteLine("Введите время в секундах:");
int time = Convert.ToInt32(Console.ReadLine());
int hours;
int minutes;
int seconds;
hours=time/3600;
minutes=(time%3600)/60;
seconds=(time%3600)%60;
Console.Write(hours);
Console.Write(":");
Console.Write(minutes);
Console.Write(":");
Console.Write(seconds);