// 18.	Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool [] arrayX={false,true};
bool [] arrayY={false,true};
bool firstBool, secondBool;

Console.WriteLine("    X      Y   !(X||Y)   !X&&!Y ");
for (int i=0;i<2; i++){
    for (int j=0; j<2 ; j++){
        firstBool=!(arrayX[i]||arrayY[j]);
        secondBool=!(arrayX[i]||arrayY[j]);
Console.WriteLine("{0,7}{1,7}{2,8}{3,8}",arrayX[i],arrayY[j],firstBool,secondBool);
Console.WriteLine();
    }
}