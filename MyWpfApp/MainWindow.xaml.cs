using System;
using System.Windows;

namespace WpfQuadraticEquation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;

            // Перевірка введення
            if (!double.TryParse(txtX.Text, out x))
            {
                ShowError("Некоректне значення X");
                return;
            }
            if (!double.TryParse(txtY.Text, out y))
            {
                ShowError("Некоректне значення Y");
                return;
            }
            if (!double.TryParse(txtZ.Text, out z))
            {
                ShowError("Некоректне значення Z");
                return;
            }

            // Додаткові перевірки для формули
            if (x <= 0)
            {
                ShowError("X має бути більше 0, бо log(x) не визначений.");
                return;
            }
            if (x + z == 0)
            {
                ShowError("Знаменник дорівнює 0 (x + z = 0).");
                return;
            }

            try
            {
                // Формула:
                // s = (lg(x) * (y + (x-1)^(1/3))^(1/4)) / (2 * |x+z|)
                double numerator = Math.Pow(y + Math.Pow(x - 1, 1.0 / 3.0), 1.0 / 4.0);
                double denominator = 2 * Math.Abs(x + z);
                double s = Math.Log10(x) * numerator / denominator;

                double result = Math.Round(s, 3);

                Console.WriteLine($"X={x}, Y={y}, Z={z} \nРезультат: s = {result}");
                MessageBox.Show($"Результат: s = {result}", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                ShowError("Помилка обчислення: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            Console.WriteLine("Помилка: " + message);
            MessageBox.Show("Помилка: " + message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
