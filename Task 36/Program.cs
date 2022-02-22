//36.Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int arrayDimension;
Console.WriteLine("Введите количество элементов массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
int[] arrayNumber = new int[arrayDimension];
int numberOdd = 0;
int numberEven = 0;
FillArray(arrayNumber);
Console.WriteLine("Масссив элементов сформирован");
CountEvenOrOddElements(arrayNumber, out numberOdd, out numberEven);
Console.WriteLine("В массиве {0} нечетных и {1} четных элементов", numberOdd, numberEven);
PrintArray(arrayNumber);
// конец программы
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(100, 1000);
    }
}

void CountEvenOrOddElements(int[] arrayN, out int numOdd, out int numEven)
{
    numOdd = 0;
    numEven = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        if (arrayN[i] % 2 == 0) numEven++;
        else numOdd++;
    }
}

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
