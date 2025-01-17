using System.Collections;


List<Pessoa> arrayBrabo = new();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"Digite a idade da {i + 1}° pessoa: ");
    int idade = int.Parse(Console.ReadLine());
    arrayBrabo.Add(new Pessoa(nome, idade));
}
Exibir(arrayBrabo);
arrayBrabo.Add(new Pessoa("Jaime", 20));
arrayBrabo.Add(new Pessoa("Tânia", 18));
Exibir(arrayBrabo);
arrayBrabo.RemoveAt(arrayBrabo.Count - 1);
Exibir(arrayBrabo);

static void Exibir(List<Pessoa> arrayBrabo)
{
    foreach (Pessoa pessoa in arrayBrabo)
    {
        Console.WriteLine(pessoa.Exibir());
    }
    Console.WriteLine();
}

class Pessoa
{
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string Exibir()
    {
        return Nome + "-" + Idade;
    }
}
