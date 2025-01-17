using Exercícios_de_List_e_Afins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Metodos;


public class Methods
{
    public void ExibirListaNotaMaiorQue8(List<Aluno> alunos)
    {
        foreach(Aluno aluno in alunos)
        {
            if(aluno.Nota > 8)
            {
                Console.WriteLine($"Aluno: {aluno.Nome} | Nota: {aluno.Nota}");
            }
        }
    }
    public void ExibirQtdOnly(List<Aluno> alunos)
    {
        int qtdAlunos = 0;
        foreach (var aluno in alunos)
        {
            qtdAlunos++;
        }
        Console.WriteLine($"\nQtd de alunos = {qtdAlunos}");
    }

    public void ExibirListaOnly(List<Aluno> alunos)
    {
        Console.WriteLine();
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.Nome} | Nota: {aluno.Nota}");
        }
        Console.WriteLine();
    }

    public void RemoverAluno(List<Aluno> alunos, string nomeDoAluno)
    {
        var aluno = alunos.Find(aluno => aluno.Nome == nomeDoAluno);
        alunos.Remove(aluno);
        Console.WriteLine($"\nAluno {nomeDoAluno} removido!");
    }
    public void AcharAluno(List<Aluno> alunos, string nomeDoAluno)
    {
        var aluno = alunos.Find(aluno => aluno.Nome.Equals(nomeDoAluno));
        if (aluno != null)
        {
            Console.WriteLine($"Aluno encontrado ({nomeDoAluno})");
        }
        else
        {
            Console.WriteLine($"Aluno não encotrado ({nomeDoAluno})");
        }

    }
    public void ExibirLista_Media_E_Quantidade(List<Aluno> alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Aluno: {aluno.Nome} | Nota: {aluno.Nota}");
        }
        double soma = 0;
        foreach (var aluno in alunos)
        {
            soma += aluno.Nota;
        }
        int qtdAlunos = 0;
        foreach (var aluno in alunos)
        {
            qtdAlunos++;
        }
        double media = soma / qtdAlunos;
        Console.WriteLine($"\nMedia = {media.ToString("F2")}");
        Console.WriteLine($"\nQtd de alunos = {qtdAlunos}");
    }
}