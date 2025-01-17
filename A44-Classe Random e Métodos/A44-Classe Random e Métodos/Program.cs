//Na classe random, o argumento seed é como se fosse um código que gera um número aleatório,
//porém se eu usar o mesma seed, ele vai gerar o mesmo número
string input;
do
{
	Random random = new(/*Seed*/);
	Console.WriteLine(random.Next());
    Console.WriteLine(random.Next(5));//Next(5) -> Gera um valor que é menor que o valor máximo definido
    Console.WriteLine(random.Next(1,101));//Next(1,101) -> Gera um valor que é menor que o valor máximo definido e igual ou maior que o valor
    //mínimo
    Console.WriteLine(random.NextDouble()); //Gera números aleatórios de ponto flutuante entre 0 e 1

    Console.WriteLine("Repetir? (Y)"); input = Console.ReadLine();
} while (input.ToUpper() == "Y");

//Sorteio 

Random aleatorio = new();
int[] numerosSorteados = new int[6];

for(int i = 0; i < numerosSorteados.Count(); i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = aleatorio.Next(1, 7);
    } while (numerosSorteados.Contains(numeroAleatorio));//Verifica se o número já foi armazenado para não ter números iguais
    numerosSorteados[i] = numeroAleatorio;
    Console.WriteLine(numerosSorteados[i]);
}


