using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть n (n > 0): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Помилка: n повинно бути цілим числом більше за 0!");
            return;
        }

        Console.Write("Введіть k (k > 0): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0)
        {
            Console.WriteLine("Помилка: k повинно бути цілим числом більше за 0!");
            return;
        }

        Console.WriteLine("\nОберіть, яку суму обчислити:");
        Console.WriteLine("1 - S1 = 1^n + 2^(n/2) + ... + k^(n/k)");
        Console.WriteLine("2 - S2 = 1^k + 2^k + ... + n^k");
        Console.WriteLine("3 - S3 = 1/n + 2/n^2 + ... + k/n^k");
        Console.Write("Ваш вибір (за замовчуванням = 1): ");

        string input = Console.ReadLine();
        int choice;

        if (string.IsNullOrWhiteSpace(input))  
            choice = 1; // ✅ якщо нічого не ввели — беремо 1
        else if (!int.TryParse(input, out choice))
        {
            Console.WriteLine("Помилка: потрібно ввести число від 1 до 3!");
            return;
        }

        double sum = 0;

        switch (choice)
        {
            case 1:
                for (int i = 1; i <= k; i++)
                {
                    sum += Math.Pow(i, (double)n / i);
                }
                Console.WriteLine($"\nS1 = {sum}");
                break;

            case 2:
                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(i, k);
                }
                Console.WriteLine($"\nS2 = {sum}");
                break;

            case 3:
                for (int i = 1; i <= k; i++)
                {
                    sum += (double)i / Math.Pow(n, i);
                }
                Console.WriteLine($"\nS3 = {sum}");
                break;

            default: // якщо користувач ввів неправильне число
                Console.WriteLine("\nПомилка: потрібно вибрати 1, 2 або 3!");
                break;
        }
    }
}
