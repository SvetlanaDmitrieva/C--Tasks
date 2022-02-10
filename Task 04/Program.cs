// По заданному номеру дня недели вывести его название

string [] nameDayWeek={"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
int numberDayWeek=0;
int i=1;
while(i<=5)
    {
    Console.WriteLine("Введите номер дня недели :");
    numberDayWeek=Int32.Parse(Console.ReadLine());
    if((numberDayWeek<=7) && (numberDayWeek > 0)) {
        Console.WriteLine("Введенному номеру недели соответствует {0,10}",nameDayWeek [numberDayWeek-1]);
        return;}
    else
        if(i<5) 
            if(i==4)Console.WriteLine("Неверно введен номер дня недели.Повторите. Осталась {0} попытка",(5-i) );
                else Console.WriteLine("Неверно введен номер дня недели.Повторите. Осталось {0} попытки",(5-i) );
     i++;
    }
    Console.WriteLine("Вы исчерпали возможное количество попыток.Запустите программу снова");
    return;
  

