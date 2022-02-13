// 8.	Показать числа от -N до N
Console.WriteLine("Введите любое  целое число :");
//
int number1;
//
number1=Math.Abs(Int32.Parse(Console.ReadLine()));

for(int i=(-number1);i<=number1;i++)
 Console.Write("{0} ", i);
