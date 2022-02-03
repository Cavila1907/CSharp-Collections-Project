using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_7.Classes
{
    class Curso
    {

        //Implementando um dicionario

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());

            }

        }


        //Campo privado contendo a lista de aulas
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {

            get { return new ReadOnlyCollection<Aula>(aulas); }

        }


        //Campos
        private string nome;
        private string professor;

        //Propriedades
        public string Nome { get => nome; set => nome = value; }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public string Professor { get => professor; set => professor = value; }

        public Curso(string nome, string professor)
        {
            this.nome = nome;
            this.professor = professor;
            this.aulas = new List<Aula>();
        }

        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public int TempoTotal
        {
            get
            {
                return aulas.Sum(aula => aula.Tempo);
            }
        }


        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            Aluno aluno = null;


            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {


            return alunos.Contains(aluno);


        }
    }
}


