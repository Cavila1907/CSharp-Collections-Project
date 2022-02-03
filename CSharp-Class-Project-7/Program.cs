using CSharp_Class_Project_7.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C#", "André Sekel");

            csharpColecoes.Adiciona(new Aula("Introdução à POO", 23));
            csharpColecoes.Adiciona(new Aula("Criando uma classe Aula", 28));
            csharpColecoes.Adiciona(new Aula("trabalhando com listas", 22));
            csharpColecoes.Adiciona(new Aula("Modelando o projeto", 24));
            //-----------------------------------------------------------//
            //Instanciar as matriculas
            Aluno a1 = new Aluno("Caio Ávila", 89010);
            Aluno a2 = new Aluno("Bruno Alves", 88210);
            Aluno a3 = new Aluno("Daniel Silva", 78090);
            Aluno a4 = new Aluno("Pedro Simplicio", 78604);
            Aluno a5 = new Aluno("Marcelo Twelve", 69010);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);
            csharpColecoes.Matricula(a4);
            csharpColecoes.Matricula(a5);


            Console.WriteLine("Imprimindo alunos matriculados: ");

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("");

            Console.WriteLine($"O aluno {a1.Nome} está matriculado? ");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));



            //Instaciando novo aluno
            Aluno avila = new Aluno("Caio Ávila", 34567);
            Console.WriteLine("Ávila está matriculado? ");
            Console.WriteLine(csharpColecoes.EstaMatriculado(avila));

            Console.WriteLine("");

            //Usando equals
            Console.WriteLine("a1 é equals Ávila? ");
            Console.WriteLine(a1.Equals(avila));
            Console.WriteLine("");
                    
            //Quem é o aluno 89010?
            Console.WriteLine("Quem é o aluno 89010?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(89010));

            //Tentando matricular outro aluno com a mesma chave
            Aluno pedro = new Aluno("Pedro Moura", 69010);
            //Substituindo aluno, após transferencia de curso
            csharpColecoes.SubstituiAluno(pedro);

            Console.WriteLine("");

            //Quem ficou com a chave 69010?
            Console.WriteLine("Quem ficou com a chave 69010 agora?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(69010));


        }
    }
}
