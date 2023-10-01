using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluno
{
    public string Matricula { get; private set; }
    public string Nome { get; private set; }
    public double NotaProva1 { get; private set; }
    public double NotaProva2 { get; private set; }
    public double NotaTrabalho { get; private set; }

    // Construtor da classe Aluno que inicializa a matrícula e o nome do aluno.
    public Aluno(string matricula, string nome)
    {
        Matricula = matricula;
        Nome = nome;
    }

    // Métodos para registrar as notas das provas e do trabalho.
    public void RegistrarNotaProva1(double nota)
    {
        NotaProva1 = nota;
    }

    public void RegistrarNotaProva2(double nota)
    {
        NotaProva2 = nota;
    }

    public void RegistrarNotaTrabalho(double nota)
    {
        NotaTrabalho = nota;
    }

    // Método para calcular a média final do aluno com os pesos especificados.
    public double CalcularMediaFinal()
    {
        double mediaProvas = (NotaProva1 + NotaProva2) * 2.5;
        double mediaTrabalho = NotaTrabalho * 2;
        double mediaFinal = (mediaProvas + mediaTrabalho) / 7.5;
        return mediaFinal;
    }
}

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira a matrícula e o nome do aluno.
        Console.WriteLine("Informe a matrícula do aluno:");
        string matricula = Console.ReadLine();

        Console.WriteLine("Informe o nome do aluno:");
        string nome = Console.ReadLine();

        // Cria um objeto Aluno com os dados fornecidos pelo usuário.
        Aluno aluno1 = new Aluno(matricula, nome);

        Console.WriteLine("Informe a nota da primeira prova:");
        double notaProva1 = Convert.ToDouble(Console.ReadLine());
        aluno1.RegistrarNotaProva1(notaProva1);

        Console.WriteLine("Informe a nota da segunda prova:");
        double notaProva2 = Convert.ToDouble(Console.ReadLine());
        aluno1.RegistrarNotaProva2(notaProva2);

        Console.WriteLine("Informe a nota do trabalho:");
        double notaTrabalho = Convert.ToDouble(Console.ReadLine());
        aluno1.RegistrarNotaTrabalho(notaTrabalho);

        double mediaFinal = aluno1.CalcularMediaFinal();

        Console.WriteLine($"Matrícula: {aluno1.Matricula}");
        Console.WriteLine($"Nome: {aluno1.Nome}");
        Console.WriteLine($"Média Final: {mediaFinal:F2}");
    }
}