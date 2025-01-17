var carro = new Carro("daniel");
carro.Ano = 1922;
Console.WriteLine(carro.Ano);
Console.WriteLine(carro.NomeInalterável);
//carro.NomeInalterável = "daniel"; Não é possivel pois a propriedade é somente leitura!
class Carro
{
    private int ano;
    public int Ano
    {
        get { return ano; } //Leitura
        set
        { // Gravação
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
        }
    }
    private string nome;
    public string Nome
    {
        get { return nome; } // SOMENTE LEITURA( IMPOSSIBILITA A GRAVAÇÃO)
    }
    private string nomeInalterável;
    public string NomeInalterável
    {
        get { return nomeInalterável; }
    }
    public Carro(string nome)
    {
        nomeInalterável = nome;
    }
}