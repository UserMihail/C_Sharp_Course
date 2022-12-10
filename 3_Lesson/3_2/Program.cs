/* Напишиет программу, которая принимает на вход
 координаты двух точек 
и находит расстояние между ними в 2D пространстве.*/

double Distance(float x1, float y1, float x2, float y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    
}

Console.WriteLine(Distance(3, 6, 2, 1));
Console.WriteLine(Distance(7, -5, 1, -1));

//второй варинат семинар 3 01:03:01

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax,2) +Math.Pow(by - ay, 2));
    return result;
}

int ax = ReadNumber("Введите aX:");
int ay = ReadNumber("Введите aY:");
int bx = ReadNumber("Введите bX:");
int by = ReadNumber("Введите bY:");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by),2));