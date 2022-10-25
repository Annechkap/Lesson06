// 1.  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных).

int[] CreatNum(int amount)

{
    int length = amount;
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        int rnd = new Random().Next(-10, 20);
        numbers[i] = rnd;
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

int Positive(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = CreatNum(5);
PrintArray(myArray);


int result = Positive(myArray);

System.Console.WriteLine($"Количество значений больше нуля:  {result}");



