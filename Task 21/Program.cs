// 21.	Программа проверяет пятизначное число на палиндромом.
//ВВод 5-значного числа
bool flag=false;
int number5digit=0,rest, i=0;
int [] figures= new int [5];
while(flag==false){
    i++;
    Console.WriteLine("Введите пятизначное число. {0} попытка из 5:", i);
    number5digit=Int32.Parse(Console.ReadLine());
        if((number5digit>9999) && (number5digit < 100000)){
        flag=true; break;
    }
    if(i==5) {System.Console.WriteLine("Вы исчерпали все попытки.");
    return;
    }
}
//Формирование массива цифр числа (в обратном порядке)
rest=number5digit;
int figLength= figures.Length;
for(i=0;i<figLength; i++){
    figures[i]=rest%10;
    rest=rest/10;
}
// Проверка, является ли введенное чмсло палиндромом 
for(i=0;i<(figLength/2);i++)
{
    if(figures[i]!=figures[figLength-i-1]) {flag=false; break; }
}
if(flag==false) Console.WriteLine("Число {0} не является палиндромом", number5digit);
    else System.Console.WriteLine("Число {0} является палиндромом", number5digit);
