//Acessando os elementos do Array Manualmente
string[] nomes = { "Marta", "Danilo", "Jerônimo" };
//                    0        1           2
Console.WriteLine(nomes[1]);
// Acessando os elementos do Array usando laço For

int valor = 1;
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}

//###Criando uma matriz 3x3###
int[,] matriz = new int[3, 3];
//Atribuindo valor a matriz
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        matriz[i, j] = valor++;
    }
}
//Digitalizando a matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i,j]);
    }
    Console.WriteLine();
}