string[] nomes = { "Daniel", "Maria", "Carlos", "Gabriel" };

Console.WriteLine("Exibindo array original");
ExibirArray(nomes);


Console.WriteLine("\n\nInvertendo a ordem do Array");
Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nOrdenando o array de volta");
Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array");
Console.WriteLine("Informe o nome");
string nome = Console.ReadLine();
var indice /*Indice retorna um valor inteiro*/= Array.BinarySearch(nomes/*<<em qual array procuro*/, /*qual nome procuro*/nome);

if (indice >= 0)
{
    Console.WriteLine($"{nome} foi encontrado com o indice = {indice}!");
}
else
{
    Console.WriteLine($"{nome} não foi encontrado!");
}
static void ExibirArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}