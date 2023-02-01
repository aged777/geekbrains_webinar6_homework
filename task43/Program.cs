// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1. Функция получения числа от пользователя с проверкой, что задано число
// 2. Функция нахождения координат точки пересечения
// 3. Ввод данных и вывод в консоль результата

// 1. Функция получения числа от пользователя с проверкой, что задано число
double getNumberFromUserWithCheck() {
    double result = 0;
    bool ifNumber = false;

    while(!ifNumber) {
        System.Console.WriteLine("Введите число: ");
        double.TryParse(Console.ReadLine(), out result);
        ifNumber = true;
    }

    return result;
}

// 2. Функция нахождения координат точки пересечения
double[] FindIntersectionPointCoordinates(double k1, double b1, double k2, double b2) {
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;   
    return result;
}

// 3. Ввод данных и вывод в консоль результата
System.Console.WriteLine("Программа найдёт координаты точки пересечения двух прямых.");
double k1, b1, k2, b2;
System.Console.WriteLine("Введите b1: ");
b1 = getNumberFromUserWithCheck();
System.Console.WriteLine("Введите k1: ");
k1 = getNumberFromUserWithCheck();
System.Console.WriteLine("Введите b2: ");
b2 = getNumberFromUserWithCheck();
System.Console.WriteLine("Введите k2: ");
k2 = getNumberFromUserWithCheck();
double[] IntersectionPoint = FindIntersectionPointCoordinates(k1, b1, k2, b2);
System.Console.WriteLine($"точка пересечения: ({IntersectionPoint[0]} ; {IntersectionPoint[1]})");
