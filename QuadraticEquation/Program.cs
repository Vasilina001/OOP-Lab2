using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double a, b, c;

        // Перевірка введення
        try
        {
            Console.Write("Введіть a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введіть b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Введіть c: ");
            c = double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Помилка: введено некоректне число!");
            return;
        }

        if (a == 0)
        {
            Console.WriteLine("Це не квадратне рівняння (a = 0).");
            return;
        }

        // Обчислення дискримінанта
        double D = b * b - 4 * a * c;
        Console.WriteLine($"\n Дискримінант D = {D}");

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Два корені: x1 = {x1}, x2 = {x2}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Один корінь: x = {x}");
        }
        else
        {
            Console.WriteLine("Розв'язків немає (D < 0).");
        }
    }
}
