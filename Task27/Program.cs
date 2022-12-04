
int number = ReadInt("Введите число: ");

int result = Sum(number);

Console.WriteLine($"Сумма цифр числа {number} равняется: {result}");


int Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

