// 23.	Показать таблицу квадратов чисел от 1 до N
int numberMax,counterNumber=0;

Console.WriteLine("Введите любое число :");
numberMax=Int32.Parse(Console.ReadLine());
Console.WriteLine("    Number  Number**2 Number  Number**2 Number  Number**2 ");
for(int i=1; i<=numberMax; i++)
{
Console.Write("{0,9}{1,9}",i ,i*i);
counterNumber++;
if(counterNumber%3==0){Console.WriteLine();}
}
