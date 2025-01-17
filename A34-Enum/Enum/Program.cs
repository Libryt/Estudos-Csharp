//Enumerações estão no arquivo de classe Enum

using Enumerations;
Console.WriteLine(/*Mostra a categoria>>*/$"{Categorias.Moda} - {(int)Categorias.Moda}"/*<<Mostra o num da categoria*/);
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} {(int)Categorias.Brinquedos}");

Console.WriteLine("Selecione a categoria teclando seu valor");
int valor = int.Parse(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"Você selecionou a categoria: {nomeMembroEnum}");


Console.ReadKey();
