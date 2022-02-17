// 6.	Написать программу вычисления значения функции y = f(a)

int numMax(int a, int b, int c)
{
    int maxNum = a;
    if (b > maxNum) maxNum = b;
    if (c > maxNum) maxNum = c;
    return maxNum;
}
int[] aNum = new int[3];
for (int i = 0; i < aNum.Length; i++)
{
    Console.WriteLine("Введите {0}-е число :", (i + 1));
    aNum[i] = Int32.Parse(Console.ReadLine());
}
Console.WriteLine("Число {0} является максимальным из введенных", numMax(aNum[0], aNum[1], aNum[2]));
