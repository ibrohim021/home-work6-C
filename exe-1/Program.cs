// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write($"Введи число (это будет кол-во чисел в массиве): ");
int num = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[num];

void InputNumbers(int number)
{
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i+1} число :");
        ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] ArrayNumbers)
{
    int count = 0;

    for(int i = 0; i < ArrayNumbers.Length; i++)
    {
        if(ArrayNumbers[i] > 0) count += 1;
    }

    return count;
}

InputNumbers(num);

Console.WriteLine($"Кол-во чисел > 0 =  {Comparison(ArrayNumbers)}");

