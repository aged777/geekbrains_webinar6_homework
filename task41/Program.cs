// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1.   Функция проверки, что задано число
// 2.   Функция ввода любого количества чисел от пользователя с созданием массива этих чисел
// 2.1  Встроенная функция увеличения массива при заполнении 
// 2.2  Встроенная функция удаления незаполненных элементов
// 3.   Функция подсчёта положительных чисел в массиве
// 4.   Демонстрация работы с выводом в консоль

// 1. Функция получения числа от пользователя с проверкой, что задано число
int getNumberFromUserWithCheck() {
    int result = 0;
    bool ifNumber = false;

    while(!ifNumber) {
        System.Console.WriteLine("Введите число: ");
        int.TryParse(Console.ReadLine(), out result);
        ifNumber = true;
    }

    return result;
}

// 2. Функция вычисления количества положительных чисел, введённых пользователем
int CountPositiveNumbersFromUser() {
    int[] tmpArray = new int[10];
    bool noMoreNumbers = false;
    int index = 0;
    int positiveNumbersCount = 0;
    while(!noMoreNumbers) {
        tmpArray[index] = getNumberFromUserWithCheck();
        if(tmpArray[index] > 0) positiveNumbersCount++;
        System.Console.Write("Желаете ввести ещё одно число?  y / n  ");
        if(index == tmpArray.Length - 1) IncreaseFilledArray(tmpArray);
        if(Console.ReadLine() == "n") noMoreNumbers = true;
        index++;
    }

    return positiveNumbersCount;

    // 2.1  Встроенная функция увеличения массива при заполнении 
    int[] IncreaseFilledArray(int[] inputArray) {
        int[] result = new int[inputArray.Length * 2]; 
        for(int i = 0; i < inputArray.Length; i++) {
            result[i] = inputArray[i];
        }
        return result;
    }
}

// 4.   Демонстрация работы с выводом в консоль
System.Console.WriteLine("Программа принимает на вход числа и выводит количество чисел больше 0.");
int positiveNumbersCount = CountPositiveNumbersFromUser();
System.Console.WriteLine($"Среди введённых чисел {positiveNumbersCount} больше 0.");
