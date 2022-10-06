int positiveNums(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item > 0) result++;
    }
    return result;
}

Console.WriteLine("Введите число чисел");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
Console.WriteLine("введите числа");
for (int i = 0; i < M; i++) array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество положительных чисел {positiveNums(array)}");
