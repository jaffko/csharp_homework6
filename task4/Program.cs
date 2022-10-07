// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 101);
        }
    }
    return result;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] findMinMax(int[,] array)
{
    int[] result = new int[4];
    int[] minIndex = new int[2];
    int[] maxIndex = new int[2];
    maxIndex[0] = 0;
    maxIndex[1] = 0;
    minIndex[0] = 0;
    minIndex[1] = 1;
    int max = array[0, 0];
    int min = array[0, 1];
    if (min > max)
    {
        max = array[0, 1];
        min = array[0, 0];
        maxIndex[1] = 1;
        minIndex[1] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                maxIndex[0] = i;
                maxIndex[1] = j;
                max = array[i,j];
            }
            else if (array[i,j] < min)
            {
                minIndex[0] = i;
                maxIndex[1] = j;
                min = array[i,j];
            }
        }
    }
    result[0] = maxIndex[0];
    result[1] = maxIndex[1];
    result[2] = minIndex[0];
    result[3] = minIndex[1];
    return result;
}

Console.WriteLine("Введите размерность массива m * n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m,n);
printArray(array);
int[] maxMinArray = new int[4];
maxMinArray = findMinMax(array);
Console.WriteLine($"Максимальный индекс = [{maxMinArray[0]},{maxMinArray[1]}], значение = {array[maxMinArray[0],maxMinArray[1]]}");
Console.WriteLine($"Минимальный индекс = [{maxMinArray[2]},{maxMinArray[3]}], значение = {array[maxMinArray[2],maxMinArray[3]]}");
