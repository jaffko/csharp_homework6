//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 

void isCrossing(float a, float c, float b, float d)
{
    if (a == b) Console.WriteLine("Прямые не пересекаются");
    else
    {
       float x = (d - c) / (a - b);
       float y = a * x + c;
       Console.WriteLine($"({x};{y})");
    }

}

Console.WriteLine("Введите k1, b1, k2, b2");
float k1 = Convert.ToInt32(Console.ReadLine());
float b1 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());
isCrossing(k1,b1,k2,b2);
