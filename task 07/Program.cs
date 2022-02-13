// 7.	Выяснить является ли число чётным
Console.WriteLine("Введите любое число :");
string str;
int number1;
str = Console.ReadLine();
number1=Int32.Parse(str);
if (number1%2==0) Console.WriteLine("Число {0} является четным", number1);
    else Console.WriteLine("Число {0} является нечетным", number1);
