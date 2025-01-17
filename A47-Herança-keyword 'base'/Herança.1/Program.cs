Derivada derivada = new();
Derivada derivada2 = new("Parâmetro");
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da Classe Base");
    }
    public Base(string nome)
    {
        Console.WriteLine("Construtor da Classe Base com Parâmetro");
    }
}

class Derivada : Base
{
    public Derivada() : base() //Primeiro executa o ctor da classe base e dps o da classe derivada
    {
        Console.WriteLine("Construtor da classe Derivada");
    }
    public Derivada(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Derivada com parâmetro"); // Primeiro executa o ctor parametrizado da classe base
        // e depois o ctor parametrizado da classe derivada
    }
}
