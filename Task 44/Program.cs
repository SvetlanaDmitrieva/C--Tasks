// 44.Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
int [] coefficientK = new int [2];
int [] coefficientB = new int [2];
for(int i=0; i<2;i++){
Console.WriteLine("Введите коэффициент k{0} {0}-й прямой", i + 1);
coefficientK[i]= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b{0} {0}-й прямой", i + 1);
coefficientB[i]= Int32.Parse(Console.ReadLine());
}
if(coefficientK[0]==coefficientK[1])
{ 
    Console.Write("Прямые не имеют точки пересечения,они параллельны,");
    Console.WriteLine("т.к. коэффициенты k1={0} и k2={1} равны",coefficientK[0], coefficientK[1]);
    return;
}
double coordinateX=(((double)coefficientB[1]-coefficientB[0])/((double)coefficientK[0]-coefficientK[1]));
double coordinateY=coordinateX*coefficientK[0]+coefficientB[0];
Console.Write("Координаты точки пересечения двух прямых:");
Console.WriteLine("X={0,8:F3}, Y={1,8:F3} ", coordinateX, coordinateY);
