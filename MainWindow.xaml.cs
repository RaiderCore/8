using System;
using System.Windows;

namespace TasksApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Task {i}");
            }
        }

        private void TaskComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ResultTextBox.Text = string.Empty;
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedTask = TaskComboBox.SelectedIndex + 1;
            string result = string.Empty;

            switch (selectedTask)
            {
                case 1:
                    result = ExecuteTask1();
                    break;
                case 2:
                    result = ExecuteTask2();
                    break;
                case 3:
                    result = ExecuteTask3();
                    break;
                case 4:
                    result = ExecuteTask4();
                    break;
                case 6:
                    result = ExecuteTask6();
                    break;
                case 7:
                    result = ExecuteTask7();
                    break;
                case 8:
                    result = ExecuteTask8();
                    break;
                case 9:
                    result = ExecuteTask9();
                    break;
                case 11:
                    result = ExecuteTask11();
                    break;
                case 12:
                    result = ExecuteTask12();
                    break;
                case 13:
                    result = ExecuteTask13();
                    break;
                case 14:
                    result = ExecuteTask14();
                    break;
                case 15:
                    result = ExecuteTask15();
                    break;
                case 16:
                    result = ExecuteTask16();
                    break;
                case 17:
                    result = ExecuteTask17();
                    break;
                case 18:
                    result = ExecuteTask18();
                    break;
                case 19:
                    result = ExecuteTask19();
                    break;
                case 20:
                    result = ExecuteTask20();
                    break;
                case 21:
                    result = ExecuteTask21();
                    break;
                case 22:
                    result = ExecuteTask22();
                    break;
                case 23:
                    result = ExecuteTask23();
                    break;
                case 24:
                    result = ExecuteTask24();
                    break;
                case 25:
                    result = ExecuteTask25();
                    break;
                case 26:
                    result = ExecuteTask26();
                    break;
                case 27:
                    result = ExecuteTask27();
                    break;
                case 28:
                    result = ExecuteTask28();
                    break;
                case 29:
                    result = ExecuteTask29();
                    break;
                case 30:
                    result = ExecuteTask30();
                    break;
                default:
                    result = "Task not implemented.";
                    break;
            }

            ResultTextBox.Text = result;
        }

       
        private string ExecuteTask1()
        {
            double x = 3.5, y = 7.2;
            bool isInside = y <= 2 - Math.Pow(x, 2) && y >= 0;
            return isInside ? "Точка A лежит в области." : "Точка A не лежит в области.";
        }

        private string ExecuteTask2()
        {
            double a = 3, b = 3.5, c = -2.1;
            double average = (a + b + c) / 3;
            return $"Среднее значение: {average}";
        }

        private string ExecuteTask3()
        {
            double x = 2, y = 1.5, R = 3;
            bool isInside = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2);
            return isInside ? "Точка лежит внутри окружности." : "Точка не лежит внутри окружности.";
        }

        private string ExecuteTask4()
        {
            double a = 3, b = 3.5, c = 4;
            bool isRightTriangle = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                                   Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                                   Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2);
            return isRightTriangle ? "Треугольник прямоугольный." : "Треугольник не прямоугольный.";
        }



        private string ExecuteTask6()
        {
            double A = -3, B = 3.5, C = 0.1;
            if (A + B + C > 0)
            {
                A *= 2; B *= 2; C *= 2;
            }
            else
            {
                A = B = C = 0;
            }
            return $"A: {A}, B: {B}, C: {C}";
        }

        private string ExecuteTask7()
        {
            double x0 = 2, y0 = 2, x1 = -4, y1 = 0;
            double distance0 = Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2));
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return distance0 < distance1 ? "Точка A ближе." : "Точка B ближе.";
        }

        private string ExecuteTask8()
        {
            double a = 3, b = 3.5, c = 3.5;
            bool isIsosceles = a == b || a == c || b == c;
            return isIsosceles ? "Треугольник равнобедренный." : "Треугольник не равнобедренный.";
        }

        private string ExecuteTask9()
        {
            double costWeekday = 0.5, costWeekend = 0.5 * 0.9; 
            double totalCost = 10 * costWeekday + 5 * costWeekend;
            return $"Общая стоимость: {totalCost}";
        }



        private string ExecuteTask11()
        {
            double a = -3, b = 3.5;
            if (a * b < 0)
            {
                a = -a;
                b = -b;
            }
            else
            {
                a = b = 0;
            }
            return $"a: {a}, b: {b}";
        }

        private string ExecuteTask12()
        {
            double a = 45, b = 13, c = -23;
            double min = Math.Min(a, Math.Min(b, c));
            return $"Наименьшее число: {min}";
        }

        private string ExecuteTask13()
        {
            double x = 3.2, y = -7, z = 0.5;
            double average = (x + y + z) / 3;
            string result = "";
            if (Math.Abs(x) > average) result += $"{x} ";
            if (Math.Abs(y) > average) result += $"{y} ";
            if (Math.Abs(z) > average) result += $"{z} ";
            return $"Числа по модулю больше среднего: {result}";
        }

        private string ExecuteTask14()
        {
            double x = 2.2, y = -6;
            bool isOnCurve = y == Math.Pow(x, 2);
            return isOnCurve ? "Точка лежит на кривой." : "Точка не лежит на кривой.";
        }

        private string ExecuteTask15()
        {
            double x = -2.2, y = -6;
            bool isInFourthQuadrant = x > 0 && y < 0;
            return isInFourthQuadrant ? "Точка в четвертой четверти." : "Точка не в четвертой четверти.";
        }

        private string ExecuteTask16()
        {
            double a = 3, b = 5, c = 4;
            double minSide = Math.Min(a, Math.Min(b, c));
            double triangleArea = Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
            double squareArea = Math.Pow(minSide, 2);
            return triangleArea > squareArea ? "Площадь треугольника больше." : "Площадь квадрата больше.";
        }

        private string ExecuteTask17()
        {
            double x1 = 9, y1 = 2, x2 = 7, y2 = 3, x3 = 0.1, y3 = 4;
            bool allInFirstQuadrant = x1 > 0 && y1 > 0 && x2 > 0 && y2 > 0 && x3 > 0 && y3 > 0;
            return allInFirstQuadrant ? "Все точки в первой четверти." : "Не все точки в первой четверти.";
        }

        private string ExecuteTask18()
        {
            double x = 1, y = 1;
            bool isOnCurve = y == Math.Pow(x, 2) && Math.Abs(x) < 2;
            return isOnCurve ? "Точка лежит на кривой." : "Точка не лежит на кривой.";
        }

        private string ExecuteTask19()
        {
            double latitude = 30, longitude = 121;
            string hemisphere = latitude > 0 ? "Северное" : "Южное";
            hemisphere += longitude > 0 ? ", Восточное" : ", Западное";
            return $"Полушарие: {hemisphere}";
        }

        private string ExecuteTask20()
        {
            double a = 3, b = 3.5, c = 1.5;
            if (a == b && b == c) return "Треугольник равносторонний.";
            if (a == b || a == c || b == c) return "Треугольник равнобедренный.";
            return "Треугольник простой.";
        }

        private string ExecuteTask21()
        {
            double A = -13, B = -3.5;
            if (A * B < 0)
            {
                A = -A;
                B = -B;
            }
            else
            {
                A = B = 0;
            }
            return $"A: {A}, B: {B}";
        }

        private string ExecuteTask22()
        {
            double a = 15, b = 13, c = -33;
            double min = Math.Min(a, Math.Min(b, c));
            return $"Наименьшее число: {min}";
        }

        private string ExecuteTask23()
        {
            int binaryNumber = Convert.ToInt32("1101011", 2);
            double a = 10, b = 34, c = 65;
            string result = "";
            if (a > binaryNumber) result += $"{a} ";
            if (b > binaryNumber) result += $"{b} ";
            if (c > binaryNumber) result += $"{c} ";
            return $"Числа больше {binaryNumber}: {result}";
        }

        private string ExecuteTask24()
        {
            int a = Convert.ToInt32("10", 8), b = Convert.ToInt32("34", 8), c = Convert.ToInt32("65", 8);
            int max = Math.Max(a, Math.Max(b, c));
            return $"Наибольшее число: {max}";
        }

        private string ExecuteTask25()
        {
            int a = Convert.ToInt32("A", 16), b = Convert.ToInt32("22", 16), c = Convert.ToInt32("41", 16);
            int min = Math.Min(a, Math.Min(b, c));
            return $"Наименьшее число: {min}";
        }

        private string ExecuteTask26()
        {
            int a = 56, b = 38;
            int sumA = (a / 10) + (a % 10);
            int sumB = (b / 10) + (b % 10);
            return $"Сумма цифр a: {sumA}, b: {sumB}";
        }

        private string ExecuteTask27()
        {
            int a = 46, b = 78;
            int productA = (a / 10) * (a % 10);
            int productB = (b / 10) * (b % 10);
            return $"Произведение цифр a: {productA}, b: {productB}";
        }

        private string ExecuteTask28()
        {
            double R1 = 5, R2 = 10, R3 = 2;
            double seriesResistance = R1 + R2 + R3;
            double parallelResistance = 1 / (1 / R1 + 1 / R2 + 1 / R3);
            return $"Последовательное сопротивление: {seriesResistance}, Параллельное сопротивление: {parallelResistance}";
        }

        private string ExecuteTask29()
        {
            double sourceVoltage = 45, spiralVoltage = 30, spiralResistance = 20;
            double requiredResistance = (sourceVoltage - spiralVoltage) / (spiralVoltage / spiralResistance);
            return $"Требуемое сопротивление реостата: {requiredResistance} Ом";
        }

        private string ExecuteTask30()
        {
            double R1 = 6, R2 = 10, R3 = 2;
            double resistorValue = 6;
            bool canGetR1 = R1 == resistorValue || R1 == 2 * resistorValue;
            bool canGetR2 = R2 == resistorValue || R2 == 2 * resistorValue;
            bool canGetR3 = R3 == resistorValue || R3 == 2 * resistorValue;
            return $"R1: {canGetR1}, R2: {canGetR2}, R3: {canGetR3}";
        }
    }
}