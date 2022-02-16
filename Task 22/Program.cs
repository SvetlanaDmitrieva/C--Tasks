// 22.	Найти расстояние между точками в пространстве 2D/3D
//Console.WriteLine("Hello, World!");
double []coordinateX = new double[2];
double []coordinateY = new double[2];
double []coordinateZ = new double[2];
double distance=0;
    
for ( int i=0; i<2; i++){
     Console.WriteLine("Введите координату Х {0}-й точки:",i+1);
     coordinateX[i]=Double.Parse(Console.ReadLine());
     Console.WriteLine("Введите координату Y {0}-й точки:",i+1);
     coordinateY[i]=Double.Parse(Console.ReadLine());
     Console.WriteLine("Введите координату Z {0}-й точки:",i+1);
     coordinateZ[i]=Double.Parse(Console.ReadLine());
 }
distance= Math.Sqrt(Math.Pow((coordinateX[0]-coordinateX[1]),2)+Math.Pow((coordinateY[0]-coordinateY[1]),2)+Math.Pow((coordinateZ[0]-coordinateZ[1]),2));
 System.Console.WriteLine("Расстояние между точками с указанными координатами равно {0}",distance );


