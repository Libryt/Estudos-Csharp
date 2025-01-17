//Acessando valores da matriz pela largura dela usando método GetLength 
double[,] matrizPronta =
{
    {10, 20, 30 },
    {40, 50, 60 },
    {70, 80 ,90 }
};
for(int i = 0; i < matrizPronta.GetLength(0); i++)
{
    for(int j = 0; j < matrizPronta.GetLength(1); j++)
    {
        Console.Write($"{matrizPronta[i,j]} ");
    }
    Console.WriteLine();
}






//### Criando matriz 3x3 ###
Console.WriteLine("\nCriando matriz 3x3:");
double[,] matrizCriada = new double[3,3];
int valor = 1;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 3; j++)
    {

        matrizCriada[i, j] += valor;
        Console.Write($"{matrizCriada[i,j]} ");
        valor++;
    }
}
