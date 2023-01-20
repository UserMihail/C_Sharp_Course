// Напишиет программу которая выводит массив из 8 цифр, и заполняет его 0 и 1 
// в случайном порядке

void Massiv(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(2);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Enter a num:");
Massiv(int.Parse(Console.ReadLine()));