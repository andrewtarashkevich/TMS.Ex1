using System;

namespace TMS.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить сколько рублей надо для покупки N долларов. Количество N задается с консоли. Курс задается рандомно.
            Console.Write("Введите количество долларов: ");
            Random rnd = new Random();
            double rate = rnd.Next(90,100);            
            double dollars = double.Parse(Console.ReadLine());
            double exchangeRes = rate * dollars;
            Console.WriteLine($"{dollars}$ на {DateTime.Now.ToString("dd/MM/yyyy")} составляет {exchangeRes} рублей");

            //Определить площадь и периметр прямоугольника.
            Console.Write("Введите высоту: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр прямоугольника = {2*(height + width)} , Площадь прямоугольника = {height * width}");

            //Два поезда выехали друг на встречу другу в одинаковое время. Определить, когда они встретятся. Скорости и расстояние задается с консоли.
            Console.Write("Введите скорость 1ого поезда: ");
            double speed1 = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость 2ого поезда: ");
            double speed2 = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние между ними: ");
            double dist = double.Parse(Console.ReadLine());
            Console.WriteLine($"Поезда встретяться через {dist / (speed1 + speed2)} часа");
        }
    }
}
