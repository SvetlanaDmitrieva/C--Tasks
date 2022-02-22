// 39.	Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int arrayDimension=1;
int flag=0;
while(arrayDimension%2!=0){
    flag++;
    if(flag>5) {
        Console.WriteLine("Вы использовали 5 возможных позиций. Выход из программы");
        return;
    }
    Console.WriteLine("Введите количество элементов массива(четное):");
    arrayDimension = Int32.Parse(Console.ReadLine());
}
int[] arrayNumber = new int[arrayDimension];
FillArray (arrayNumber);
PrintArray(arrayNumber);
PrintMultiplyArray(arrayNumber);
//
void FillArray(int[] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
    {
        arrayN[i] = new Random().Next(10, 100);
    }
}
//
void PrintArray(int[] arrayN)
{
    int flag = 0;
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.Write("a[{0,3}]= {1,3} | ", i, arrayN[i]);
        flag++;
        if (flag % 4 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}
//
void PrintMultiplyArray(int[] arrayN)
{
    int flag = 0;
    int arrayLength=arrayN.Length;
    Console.WriteLine(" Произведение пар чисел:" );
    for (int i = 0; i < (arrayLength/2); i++)
    {
        Console.Write("(a[{0,3}]{1,3} * a[{2,3}]{3,3})= {4,5} |", i,arrayN[i],(arrayLength-i-1),
                     arrayN[arrayLength-i-1],(arrayN[i]*arrayN[arrayLength-i-1]));
        flag++;
        if (flag % 2 == 0) { Console.WriteLine(); }
    }
    Console.WriteLine();
}
