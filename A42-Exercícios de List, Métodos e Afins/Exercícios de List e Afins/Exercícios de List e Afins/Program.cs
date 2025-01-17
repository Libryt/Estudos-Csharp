using System;
using System.Collections.Generic;
using Metodos;
namespace Exercícios_de_List_e_Afins;

class Program
{
    public static void Main(string[] exList)
    {
        Methods metodos = new();
        List<Aluno> alunos = new()
        {
            new Aluno("Maria", 8.75),//É preciso criar a instância de cada objeto 
            new Aluno("Manoel", 6.95), //Por causa do constructor, é necessário por uma string e um número.
            new Aluno("Amanda", 7.25),
            new Aluno("Carlos", 6.55),
            new Aluno("Jaime", 8.50),
            new Aluno("Debora", 5.95),
            new Aluno("Alicia", 9.25),
            new Aluno("Sandra", 5.55),
            new Aluno("Marta", 7.85),
            new Aluno("Sueli", 9.15)
        };
        
        metodos.ExibirLista_Media_E_Quantidade(alunos);
        metodos.AcharAluno(alunos, "Manoel");
        alunos.Add(new Aluno("Bia", 7.75));
        alunos.Add(new Aluno("Mario", 8.75));
        metodos.ExibirListaOnly(alunos);
        metodos.ExibirQtdOnly(alunos);
        metodos.RemoverAluno(alunos, "Amanda");
        metodos.ExibirQtdOnly(alunos);
        var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList(); // Aqui é necessário usar o ToList() pois o método orderBy retorna
        // UM iNumerable, e não um tipo List<>, sendo assim não é possível passar como argumento para o parâmetro do método.
        metodos.ExibirListaOnly(listaOrdenada);
        metodos.ExibirListaNotaMaiorQue8(alunos);

    }
    
}
public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }
    public Aluno(string nome, double nota) //Constructor limita a criação do objeto com os seguintes parâmetros
    {
        Nome = nome;
        Nota = nota;
    }
}
