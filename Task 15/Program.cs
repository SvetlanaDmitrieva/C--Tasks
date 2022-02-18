// 15.	Найти третью цифру числа или сообщить, что её нет

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