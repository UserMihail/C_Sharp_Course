// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23

/*Вариант 1
Console.WriteLine("Введите число ");
int a = int.Parse(Сonsole.ReadLine());

if ( a % 7 ==0) 
{
    if ( a % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23");
}
else
   Console.WriteLine("Число не кратно 7 и 23");*/

   //Вариант 2(составной)

   string divisible(int num)
   {
        if (num % 7 == 0 && num % 23 == 0)
            return "divisible";
        else
            return "non-divisible";
   } 
   Console.WriteLine("enter number");
   int number = int.Parse(Console.ReadLine());
   Console.WriteLine(divisible(number));