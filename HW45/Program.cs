﻿// 45. Показать числа Фибоначчи
// 0, 1, 1, 2, 3, 5, 8, 13, 21
//последовательность, где первые 2 числа равны 1 и 1, или 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел.
int [] Array = new int [8];
int k = 1;
int n = 2;
Array[0] = k;
Array[1] = k;
while (n <= 7)
{
    Array[n] = (Array[n-1] + Array[n-2]);
    Console.WriteLine(Array[n]);
    n ++;
}


