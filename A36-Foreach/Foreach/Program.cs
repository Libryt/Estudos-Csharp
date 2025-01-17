//O foreach serve para ler e recuperar elementos dentro de coleções(Arrays, List, ArrayList, Stack, Queue, etc).
//Sintaxe >> foreach(tipo do valor da coleção + variável + in + nome da coleção)

int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach(int v in vetor)
{
    Console.WriteLine(v);
}
Console.WriteLine();
string[] nomes = { "Lohan", "José", "Alfredo" };

foreach(string nome in nomes) //Tradução: Para cada nome string nome na coleção nome, faça:
{
    Console.WriteLine(nome);
}
