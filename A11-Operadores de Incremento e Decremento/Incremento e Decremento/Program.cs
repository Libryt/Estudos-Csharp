//Incremento e Decremento Padrão

int x = 10;
x++; // 10+1 #Incremento
System.Console.WriteLine($"Esse é o valor com de x com incremento: {x}");
x--;// 11-1 #Decremento
x--; // 10-1 #Decremento
System.Console.WriteLine($"Esse é o valor com de x com decremento: {x}");

//Isso é a mesma coisa que: y = 0; y += 10 -> R: 10 | ou y = 0; y = 0+1;   \n");
System.Console.WriteLine("y = 0; \ny += 10; ");

//Pós e Pré-incremento
//#Pós-incremento:
int a = 0;
int pós = a++ + 10; // primeiro resolve a expressão (a+10) e depois incrementa +1 no valor de a
System.Console.WriteLine("---Pós-incremento---");
System.Console.WriteLine("Valor base: " + a);
System.Console.WriteLine("Valor pós-incremento(expressão): " + pós);
System.Console.WriteLine("Valor pós-incremento(valor adicionado à váriavel): " + a);
System.Console.WriteLine("---Pré-Incremento---");
//#Pré-incremento
int b = 0;
int pré = ++b + 10; // primeiro incrementa +1 no valor de b e depois resolve a expressão (x(com incremento) + 10)
System.Console.WriteLine("Valor base: " + b);
System.Console.WriteLine("Valor pré-incremento(expressão com o incremento): " + pré);
System.Console.WriteLine("O valor base + incremento: " + b);

//#Para Pré e Pós-decremento é a mesma coisa, só basta mudar o sinal de x++ para x--, ou ++x para --x
Console.ReadKey();