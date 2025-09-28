using System;
using System.Windows;

namespace QuadraticSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;

            // Перевірка введення
            if (!double.TryParse(textA.Text, out a) ||
                !double.TryParse(textB.Text, out b) ||
                !double.TryParse(textC.Text, out c))
            {
                MessageBox.Show("Помилка: введіть правильні числа!");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("Це не квадратне рівняння (a = 0)!");
                return;
            }

            double D = b * b - 4 * a * c;
            labelD.Content = $"Дискримінант D = {D}";

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                labelX1.Content = $"x1 = {x1}";
                labelX2.Content = $"x2 = {x2}";

                labelX1.Visibility = Visibility.Visible;
                labelX2.Visibility = Visibility.Visible;
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                labelX1.Content = $"x = {x}";

                labelX1.Visibility = Visibility.Visible;
                labelX2.Visibility = Visibility.Hidden;
            }
            else
            {
                labelX1.Content = "Розв'язків немає!";
                labelX2.Content = "";

                labelX1.Visibility = Visibility.Visible;
                labelX2.Visibility = Visibility.Hidden;
            }
        }
    }
}
