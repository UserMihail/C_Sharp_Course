﻿/* Напишиет программу, которая принимает на вход координаты точки (X и Y),
причем Х=/0 или Y=/0 и выдает номер четверти плоскости, в которой
находится точка.*/

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
         Console.WriteLine("I");
    else if (x < 0 && y > 0)
         Console.WriteLine("II");
    else if (x < 0 && y < 0)
         Console.WriteLine("III");
    else if (x > 0 && y < 0)
         Console.WriteLine("IV");
         
      
}      
Quarters(-10, -9);//(0, 9) I(10, 9) II(-10, 9) III(-10, -9)