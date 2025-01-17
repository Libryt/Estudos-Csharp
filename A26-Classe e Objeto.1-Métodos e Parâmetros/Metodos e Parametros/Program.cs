//Sem parâmetro
Metodos metodos = new();
metodos.saudacao();
//Com parametro
ClasseComParametro classeComParametro = new();


// ClasseComParametro.classeComParametro(); //! Dará erro pois o método tem parâmetros e os parâmetros não são citados.
classeComParametro.saudar("Daniel", DateTime.Now.ToShortDateString()); //? Dá certo pois apresenta os parâmetros requiridos pelo

//TODO\\ Definindo uma classe como parâmetro de outra
var aluno = new Aluno();
System.Console.WriteLine("Digite o nome do aluno:");
aluno.Nome = Console.ReadLine();
System.Console.WriteLine("Digite o sexo do aluno:");
aluno.Sexo = Console.ReadLine();
System.Console.WriteLine("Digite a idade do aluno:");
aluno.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite (S) se o aluno foi aprovado ou (N) se foi reprovado");
aluno.Aprovado = Console.ReadLine();

//? Crio a classe Resultado para mostrar o resultado

ResultadoDoCurso resultado = new();
resultado.Resultado(aluno);
Console.ReadKey();


//TODO\\ Definindo um objeto como parâmetro de um método.
class Aluno
{
    public string Nome;
    public int Idade;
    public string Sexo;
    public string Aprovado;
}
class ResultadoDoCurso
{
    public void Resultado(Aluno aluno)
    {
        System.Console.WriteLine($"\n O Aluno {aluno.Nome}, de sexo {aluno.Sexo} com {aluno.Idade} anos foi");
        if(aluno.Aprovado == "S")
        {
            System.Console.Write("aprovado");
        }
        else
        {
            System.Console.WriteLine("reprovado");
        }
    }
}



class ClasseComParametro
{
    public void saudar(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);

    }
}
class Metodos
{
    public void saudacao()
    {
        Console.WriteLine("Olá Mundo");
    }
}
