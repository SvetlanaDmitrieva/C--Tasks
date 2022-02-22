//35.	Определить, присутствует ли в заданном массиве, некоторое число
int arrayDimension, flag;
Console.WriteLine("Введите количество элементов массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
int[] arrayNumber = new int[arrayDimension];
int number = 0;
FillArray(arrayNumber);
Console.WriteLine("Масссив элементов сформирован");
int yesNo;
string again = "y";
while (again == "y" || again == "н")
{
    Console.WriteLine("Введите число для поиска в полученном массиве в интервале от -99 до 99:");
    number = Int32.Parse(Console.ReadLine());
    yesNo = SearchElement(arrayNumber, number);
    if (yesNo == -1)
    {
        Console.WriteLine("Указанное число не найдено.Повторить поиск?(y/n)");
        again = (Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Указанное число найдено, {0} элемент массива", yesNo);
        break;
    }
}
PrintArray(arrayNumber);
// конец программы
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(-99, 100);
    }
}
//  
int SearchElement(int[] arrayN, int Num)
{
    flag = -1;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (arrayN[i] == Num)
        {
            flag = i; break;
        }
    }
    return flag;
}
//
void PrintArray(int[] arrayN)
{
    flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,2}]= {1,4} | ", i, arrayN[i]);
        flag++;
        if (flag % 3 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}
