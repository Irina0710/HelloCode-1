﻿// 41. Выяснить являются ли три числа сторонами треугольника 
// сумма длины двух сторон должна быть больше 3-й, проверив все 3 возможные комбинации сумм, 3 условия должны выполняться
int a = 4;
int b = 7;
int c = 9;

if (a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine ("Три числа являются сторонами треугольника");

}
else Console.WriteLine ("Три числа не являются сторонами треугольника");