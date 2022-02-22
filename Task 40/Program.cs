//40.В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int arrayDimension;
double maxNumber, minNumber;
Console.WriteLine("Введите количество элементов массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
double[] arrayNumber = new double[arrayDimension];
FillArray(arrayNumber, out minNumber, out maxNumber);
PrintArray(arrayNumber);
Console.Write("Максимальный элемент массива - {0,8:F4}, минимальный - {1,8:F4}, ", maxNumber, minNumber);
Console.WriteLine("разница между ними -{0,8:F4} ", (maxNumber - minNumber));
//
void FillArray(double[] arrayN, out double numMin, out double numMax)
{
    numMin = 100.0;
    numMax = 0.0;
    Random rnd = new Random();
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = rnd.NextDouble() * 100.0;
        if (arrayN[i] < numMin) numMin = arrayN[i];
        if (arrayN[i] > numMax) numMax = arrayN[i];
    }
}
//
void PrintArray(double[] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,2}]= {1,8:F4} | ", i, arrayN[i]);
        flag++;
        if (flag % 3 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}