Aluno aluno = new(11,"daniel","M","A"); //? Criação do objeto cujo necessita dos limites impostos pelo constructor
Console.ReadKey();


var isso = new This("x","y",1); //? Criação do objeto com o uso do this.

class Aluno
{
public Aluno(int idade, string? nome, string? sexo, string aprovado) //*Constructor
{   //! O Constructor limita como o objeto pode ser criado
    Idade = idade; //Atribui as variáveis do constructor à as classes já criadas
    Nome = nome;
    Sexo = sexo;
    Aprovado = aprovado;
}  //Criação dos métodos
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

class This
{
    public This(string x, string y, int z)
    {
        this.X = y;
        this.Y = y;
        this.Z = z; 
    }
    public string X;
    public string Y;
    public int Z;
}