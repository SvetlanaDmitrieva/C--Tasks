// 14.	Выяснить, кратно ли число заданному, если нет, вывести остаток.

int Num1,Num2,Rest;
Console.WriteLine("Введите первое число :");
Num1=Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число :");
Num2=Int32.Parse(Console.ReadLine());
Rest=Num1%Num2;
if(Rest==0) Console.WriteLine("Первое число {0}  кратно второму числу {1}", Num1,Num2); 
else 
{
    Console.WriteLine("Первое число {0}  не кратно второму числу {1}, остаток от деления - {2}", Num1,Num2,Rest);
}
