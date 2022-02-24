//46.Написать программу масштабирования фигуры
double[,] coordinates = new double[4, 4];
double scale;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine("Введите {0} координату  {1}-й точки:", j + 1, i + 1);
        coordinates[i, j] = Double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите коэффициент масштабирования :");
scale = Double.Parse(Console.ReadLine());
PrintArray(coordinates);
System.Console.WriteLine("Масштабированная фигура :");
ChangeScale(coordinates, scale);
PrintArray(coordinates);
// конец программы*/
void ChangeScale(double[,] arrayN, double sc)
{
    for (int i = 0; i < arrayN.GetLength(0); i++)
    {
        for (int j = 0; j < 2; j++)
            arrayN[i, j] = arrayN[i, j] * sc;
    }
}
//
void PrintArray(double[,] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.GetLength(0); i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write("a[{0,2},{1,2}]={2,6:F2} |", i, j, arrayN[i, j]);
            flag++;
        }
        //Console.Write(" flag={0} ",flag);
        if (flag % 2 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}