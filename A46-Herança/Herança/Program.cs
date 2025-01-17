int aluno_1 = Pessoa.PedirCPF();
Aluno aluno1 = new("Daniel", aluno_1, 7.5f, 78.4241212f);
Aluno.Alunos.Add(aluno1);
Aluno.ExibirAluno();

class Pessoa //Classe Principal
{
    public string Nome { get; set; }
    public int CPF { get; set; }
    public static dynamic PedirCPF()
    {
        int cpf = int.Parse(Console.ReadLine());
        return cpf;
    }
    
}
class Aluno : Pessoa //Classe Derivada, Herda atributos "Nome", "CPF" e Método "PedirCPF".
{
    public static List<Aluno> Alunos = new();
    public float Nota { get; set; }
    public float Frequencia;
    public Aluno(string nome, int cpf, float nota, float frequencia)
    {
        Nome = nome;
        CPF = cpf;
        Nota = nota;
        Frequencia = frequencia;
    }
    public override string ToString()
    {
        return $"Nome:{Nome},CPF: {CPF},Nota = {Nota}, Frequencia = {Frequencia}.";
    }
    public static void ExibirAluno()
    {
        
        foreach(var aluno in Alunos)
        {
            Console.Write(aluno.ToString()+" ");
        }
    }
}