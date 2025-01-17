//Criar um programa em c# usando For para exibir a tabuada de multiplicação de números inteiros
Console.WriteLine("Digite a tabuada da qual você quer:\n");
int num = int.Parse(Console.ReadLine());
int multiplicador;
for (multiplicador = 1; multiplicador < 11; multiplicador++){
    Console.WriteLine($"{num}x{multiplicador} = {num*multiplicador}");
}

//mesmo código só que com while
System.Console.WriteLine("Digite a tabuada da qual você quer:\n");
int x = int.Parse(Console.ReadLine());
int mt = 1;
while (mt < 11) {
    Console.WriteLine($"{x}x{mt} = {x*mt}");
    mt++;
}

//Instrução continue

for (int n = 1; n <= 10; n++)
{
    if (n == 3)
    {
        continue;
    }
        System.Console.WriteLine($"N = {n}");
}










Console.ReadKey();