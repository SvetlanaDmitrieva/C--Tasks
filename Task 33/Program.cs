// 33.	Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int sumPozitive = 0, sumNegative = 0;
int flag = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] < 0) { sumNegative += array[i]; }
    else sumPozitive += array[i];
    Console.Write("a[{0,2}]= {1,4} |", i, array[i]);
    flag++;
    if (flag % 3 == 0) { System.Console.WriteLine(); }
}
Console.WriteLine("Сумма положительных элементов - {0,4}, отрицательных - {1,4}"
                    , sumPozitive, sumNegative);

