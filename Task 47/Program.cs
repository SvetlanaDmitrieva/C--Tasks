// 47.Написать программу копирования массива
int arrayDimension;
Console.WriteLine("Введите количество элементов массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
int[] arrayNumber = new int[arrayDimension];
int [] copyArrayNumber= new int[arrayDimension];
FillArray(arrayNumber);
PrintArray(arrayNumber);
Console.WriteLine("Скопированный массив:");
for (int i=0; i<arrayNumber.Length; i++)
{
    copyArrayNumber [i]=arrayNumber[i];
}
PrintArray(copyArrayNumber);
//
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(-99, 100);
    }
}
//
void PrintArray(int[] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,2}]= {1,4} | ", i, arrayN[i]);
        flag++;
        if (flag % 3 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}