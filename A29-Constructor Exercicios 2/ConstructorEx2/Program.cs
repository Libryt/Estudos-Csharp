// Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
// use a palavra-chave this)
// Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
// vai retornar um double representando a velocidade máxima do car

var carro = new Carro("Ford", "Fiesta");

Console.WriteLine(carro.VelocidadeMaxima(20));
Console.ReadKey();
class Carro
{
    public Carro(string Modelo, string Montadora)
    {
    }
    
    public string Modelo;
    public string Montadora;

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}