 int A = 1;
while(A <= 10)
{
    Console.WriteLine($"O valor de A é {A}");
    A++;

}
System.Console.WriteLine("Fim de processo 1");
int B = 10;
while (B > 0)
{
    Console.WriteLine($"O valor de B é {B}");
    B--;
}

System.Console.WriteLine("Digite a tabuada que você quer");
int tabuada = int.Parse(Console.ReadLine());
if (tabuada > 0)
{
    int x = 1;
    while(x <= 10)
    {
        int calculo = tabuada*x;
        Console.WriteLine($"{tabuada}*{x} = {calculo}\n");
        x++;
    }
}
else {
    System.Console.WriteLine("Numero invalido para tabuada");
}


Console.ReadKey();