// Напишите программу которая принимает на вход число и выводит количество 
// цифр в этом числе.

int SumNams(int num)
{
    int count = 0;
    while (num > 0)
        {
            num = num / 10;
            all_sum++;
        }
    
    return count;
}

Console.WriteLine(SumNams(int.Parse(Console.ReadLine())));
