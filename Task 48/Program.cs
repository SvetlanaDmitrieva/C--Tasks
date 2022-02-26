// 48.Показать двумерный массив размером m×n заполненный целыми числами
int numberOfLines, numberOfColumns;
Console.WriteLine("Введите количество строк массива:");
numberOfLines = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
numberOfColumns = Int32.Parse(Console.ReadLine());
int[,] arrayNumber = new int[numberOfLines, numberOfColumns];
FillArray(arrayNumber);
PrintArray(arrayNumber);
//
void FillArray(int[,] arrayN)
{
    for (int i = 0; i < arrayN.GetLength(0); i++)
        for (int j = 0; j < arrayN.GetLength(1); j++)
        {
            arrayN[i, j] = new Random().Next(-99, 100);
        }
}
//
void PrintArray(int[,] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.GetLength(0); i++)
        for (int j = 0; j < arrayN.GetLength(1); j++)
        {
            Console.Write("a[{0,2},{1,2}]= {2,4} | ", i, j, arrayN[i, j]);
            flag++;
            if (flag % 3 == 0) { Console.WriteLine(); }
        }
    Console.WriteLine();
}