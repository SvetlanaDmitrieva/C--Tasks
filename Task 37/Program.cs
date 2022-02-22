//37.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] arrayNumber = new int[123];
int numInterval;
//
FillArray(arrayNumber);
numInterval = SearchElementInterval(arrayNumber);
PrintArray(arrayNumber);
Console.WriteLine("В массиве {0} элементов находятся в интервале [10,99] :", numInterval);

// конец программы*/
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    { arrayN[i] = new Random().Next(0, 1000); }
}
int SearchElementInterval(int[] arrayN)
{
    int numberInInterval = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (arrayN[i] >= 10 && arrayN[i] <= 99)
            numberInInterval++;
    }
    return numberInInterval;
}

void PrintArray(int[] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,4}]= {1,4} | ", i, arrayN[i]);
        flag++;
        if (flag % 3 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}
