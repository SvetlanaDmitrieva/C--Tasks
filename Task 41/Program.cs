//41.Выяснить являются ли три числа сторонами треугольника
bool flag;
int[] sidesOfTriangle = new int[3];
for (int i = 0; i < sidesOfTriangle.Length; i++)
{
    Console.WriteLine("Введите {0} число (сторона треугольника):", i + 1);
    sidesOfTriangle[i] = Int32.Parse(Console.ReadLine());
}
PrintArray(sidesOfTriangle);
flag = ChekSidesTriangle(sidesOfTriangle);
if (flag) { Console.WriteLine("Числа являются сторонами треугольника"); }
else { Console.WriteLine("Числа не являются сторонами треугольника"); }

// конец программы*/
bool ChekSidesTriangle(int[] arrayN)
{
    bool fl = true;
    int lengthArray = arrayN.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        for (int j = i + 1; j < lengthArray; j++)
        {
            if (arrayN[i] + arrayN[j] <= arrayN[lengthArray - i - j])
            {
                fl = false;
                break;
            }
        }
    }
    return fl;
}
void PrintArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,2}]={1,3} | ", i, arrayN[i]);
    }
    Console.WriteLine();
}