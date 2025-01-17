//Operadores Aritméticos 

Console.WriteLine("Informe o Valor de x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o Valor de y");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nA soma entre x e y é: {x+y}");//Soma

Console.WriteLine($"\nA subtração entre x e y é: {x-y}");//Subtração

Console.WriteLine($"\nA multiplicação entre x e y é: {x*y}");//Multiplicação

Console.WriteLine($"\nA divisão entre x e y é: {x/y}");//Divisão

Console.WriteLine($"\nA potência de x elevado a y é: {Math.Pow(x,y)}");//Potência

Console.WriteLine($"\nA raiz quadrada de x somado com y é: {Math.Sqrt(x+y)}");//Raiz Quadrada

Console.WriteLine($"\nO maior entre x e y é: {Math.Max(x,y)}");//Maior entre dois números

Console.WriteLine($"\n\aO menor entre x e y é: {Math.Min(x,y)}");//Menor entre dois números

Console.WriteLine($"\n\aO seno de x + y é: {Math.Sin(x+y)}");//Seno

Console.WriteLine($"\n\aO coseno de x + y é: {Math.Cos(x+y)}");//Cosseno

Console.WriteLine($"\n\aA de x + y é: {Math.Tan(x+y)}");//Tangente 

Console.ReadKey();