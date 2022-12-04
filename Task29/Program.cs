Console.WriteLine("Введите 8 чисел");

int count = 8;
int[] arr = new int[count];

InputNumbers(count, arr);

WriteNumbers(count, arr);

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void InputNumbers(int count, int[] arr)
{
    for (int i = 0; i < count; i++)
        arr[i] = ReadInt("Введите число: ");
}

void WriteNumbers(int count, int[] arr)
{
    for (int i = 0; i < count; i++)
        Console.Write(arr[i] + " ");
}