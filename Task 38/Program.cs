//38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int arrayDimension;
Console.WriteLine("Введите количество элементов массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
int[] arrayNumber = new int[arrayDimension];
FillArray(arrayNumber);
PrintArray(arrayNumber);
int sumElements=SumOddNumberElements(arrayNumber);
Console.WriteLine("Сумма чисел, стоящих на нечетной позиции, равна {0, 5}", sumElements);
/*
Console.WriteLine("Hello, World!");

int numberOdd = 0;
int numberEven = 0;

Console.WriteLine("Масссив элементов сформирован");
CountEvenOrOddElements(arrayNumber, out numberOdd, out numberEven);
Console.WriteLine("В массиве {0} нечетных и {1} четных элементов", numberOdd, numberEven);
PrintArray(arrayNumber);
// конец программы
*/
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(10, 100);
    }
}

int SumOddNumberElements(int[] arrayN)
{
    int sumNumberOdd = 0;
  //  numEven = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (i % 2 != 0) sumNumberOdd+= arrayN[i];
    }
    return sumNumberOdd;
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
