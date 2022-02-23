// 45.Показать числа Фибоначчи
int numFibonacci ;
Console.WriteLine("Введите число, до какого нужно вывести последоаптельность Фибоначчи :");
numFibonacci = Math.Abs(Int32.Parse(Console.ReadLine()))+1;
int [] arrayFibonacci= new int[numFibonacci];
FillArray(arrayFibonacci);
Console.WriteLine("Получена следующая последовательность Фибоначчи");
PrintArray(arrayFibonacci);
//
void FillArray(int[] arrayN)
{
 int arrayLength=arrayN.Length;   
arrayN[0]=1;
if(arrayLength==0) return;
arrayN[1]=1;
 if(arrayLength==1) return;
    for (int i = 2; i < arrayN.Length; i++)
    {
        arrayN[i] = arrayN[i-1]+arrayN[i-2];
    }
}

/*
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
*/
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
/*
Console.WriteLine("Hello, World!");
int[] numberAll = new int[12];
int Num, Flag = 0, rest;
Console.WriteLine("Введите любое число :");
Num = Int32.Parse(Console.ReadLine());
rest = Num;
for (int i = 0; i < numberAll.Length; i++)
{
    numberAll[i] = rest % 10;
    rest = rest / 10;
    if (rest == 0) { Flag = i + 1; break; }
}
if (Flag < 3) Console.WriteLine("Введенное число {0} меньше 100, не имеет третьей цифры", Num);
else
    Console.WriteLine("Третья цифра числа {0} - {1}", Num, numberAll[Flag - 3]);
*/
