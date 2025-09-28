using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double x, y, z;

        // Перевірка введення
        Console.Write("Введіть x: ");
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Помилка: введено некоректне число для x!");
            return;
        }

        Console.Write("Введіть y: ");
        if (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Помилка: введено некоректне число для y!");
            return;
        }

        Console.Write("Введіть z: ");
        if (!double.TryParse(Console.ReadLine(), out z))
        {
            Console.WriteLine("Помилка: введено некоректне число для z!");
            return;
        }

        // Перевірки коректності значень
        if (x <= 0)
        {
            Console.WriteLine("Помилка: log10(x) визначено тільки для x > 0!");
            return;
        }

        if (x + z == 0)
        {
            Console.WriteLine("Помилка: ділення на нуль (x + z = 0)!");
            return;
        }

        // Обчислення
        double numerator = Math.Log10(x) * Math.Pow(y + Math.Pow(x - 1, 1.0 / 3.0), 1.0 / 4.0);
        double denominator = 2 * Math.Abs(x + z);
        double s = numerator / denominator;

        // Заокруглення до 3 знаків після коми
        s = Math.Round(s, 3);

        Console.WriteLine($"\nРезультат: s = {s}");
    }
}