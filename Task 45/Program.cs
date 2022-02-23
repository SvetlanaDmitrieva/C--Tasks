// 45.Показать числа Фибоначчи
int numFibonacci;
Console.WriteLine("Введите число, до какого нужно вывести последоаптельность Фибоначчи :");
numFibonacci = Math.Abs(Int32.Parse(Console.ReadLine()));
int[] arrayFibonacci = new int[numFibonacci + 1];
FillArray(arrayFibonacci);
Console.WriteLine("Получена следующая последовательность Фибоначчи");
PrintArray(arrayFibonacci);
//
void FillArray(int[] arrayN)
{
    int arrayLength = arrayN.Length;
    arrayN[0] = 1;
    if (arrayLength == 1) return;
    arrayN[1] = 1;
    if (arrayLength == 2) return;
    for (int i = 2; i < arrayN.Length; i++)
    {
        arrayN[i] = arrayN[i - 1] + arrayN[i - 2];
    }
}
//
void PrintArray(int[] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("nFibonacci({0,2})={1,9} | ", i, arrayN[i]);
        flag++;
        if (flag % 3 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}