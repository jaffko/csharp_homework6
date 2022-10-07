// На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

bool isTriangle(double a, double b, double c)
{
    bool result = true;
    if (a > b + c || b > a + c || c > a + b) result = false;
    return result;
}

string[] TriangleInfo(double a, double b, double c)
{
    // значение углов arccos(b2+c2-a2/2bc)
    string[] result = new string[4];
    double alpha = Math.Round(Math.Acos((a*a + b * b - c * c)/(2*a*b)) * (180 / Math.PI),2);
    double beta = Math.Round(Math.Acos((b*b + c * c - a * a)/(2*b*c)) * (180 / Math.PI),2);
    double gamma = Math.Round(Math.Acos((c*c + a * a - b * b)/(2*a*c)) * (180 / Math.PI),2);
    if (alpha == 90 || beta == 90 || gamma == 90) result[0] = "Прямоугольный";
    else if (a == b && b == c) result[0] = "Равносторонний";
    else if (a == b || b == c || a == c) result[0] = "Равнобедренный";
    result[1] = $"Углы треулогльника = {alpha}, {beta}, {gamma}";
    double P = a+b+c;
    result[2] = $"Периметр треугольника = {P}";
    double S = Math.Sqrt(P/2*(P/2-a)*(P/2-b)*(P/2-c));
    result[3] = $"Площадь треугольника = {S}";
    return result;
}

Console.WriteLine("Введите три стороны треугольника");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
if (!isTriangle(a,b,c)) Console.WriteLine("Треугольника не существует");
else
{
    string[] array = TriangleInfo(a,b,c);
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}
