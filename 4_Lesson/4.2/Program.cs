// напишите программу которая принимает на вход число N, и 
// выводит произведение чисел от 1 до N

int NumProiz(int num)
{
    int Proiz = 1;
    for (int i = 1; i <= num; i++)
    {
        Proiz *= i;
    }
    return Proiz;
}

Console.WriteLine(NumProiz(int.Parse(Console.ReadLine())));