// 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Number(string message)
{
    Console.WriteLine(message);
    double numbers = Convert.ToInt32(Console.ReadLine());

    return numbers;
}

double k1 = Number("Введите k1");
double b1 = Number("Введите b1");
double k2 = Number("Введите k2");
double b2 = Number("Введите b2");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;


Console.WriteLine($"Пересечение в точке: ({x} ; {y})");
