//42.Определить сколько чисел больше 0 введено с клавиатуры
int arrayDimension, amountPozitiveNum;
Console.WriteLine("Введите максимальное количество вводимых целых чисел массива:");
arrayDimension = Int32.Parse(Console.ReadLine());
int[] arrayNumber = new int[arrayDimension];
FillArray(arrayNumber, out amountPozitiveNum);
Console.WriteLine("Масссив элементов сформирован, введено {0} положительных чисел:", amountPozitiveNum);
PrintArray(arrayNumber);
// конец программы
void FillArray(int[] arrayN, out int amountNumbers)
{
    amountNumbers = 0;
    string again = "y";
    for (int i = 0; i < arrayN.Length; i++)
    {
        Console.WriteLine("Введите {0} число(любое целое): ", i + 1);
        arrayN[i] = Int32.Parse(Console.ReadLine());
        if (arrayN[i] > 0) { amountNumbers++; }
        if (i == (arrayN.Length - 1)) break;
        Console.WriteLine("Число введено.Продолжить ввод?(y/n)");
        again = (Console.ReadLine());
        if (again == "y" || again == "н") continue;
        else break;
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
