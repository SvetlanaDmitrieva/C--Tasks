// 24.	Найти кубы чисел от 1 до N
int numberMax,counterNumber=0;
Console.WriteLine("Введите любое число :");
numberMax=Int32.Parse(Console.ReadLine());
Console.WriteLine("    Number  Number**3 Number  Number**3 Number  Number**3 ");
for(int i=1; i<=numberMax; i++)
{
Console.Write("{0,9}{1,9}",i ,i*i*i);
counterNumber++;
if(counterNumber%3==0){Console.WriteLine();}
if(counterNumber%12==0){Console.WriteLine();}
}


//Console.WriteLine("Hello, World!");
/*
Console.WriteLine("Введите любое число :");
numberMax=Int32.Parse(Console.ReadLine());
Console.WriteLine("    Number  Number**2 Number  Number**2 Number  Number**2 ");
for(int i=1; i<=numberMax; i++)
{
Console.Write("{0,9}{1,9}",i ,i*i);
counterNumber++;
if(counterNumber%3==0){Console.WriteLine();}
}*/
