using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_7.Classes
{
    class Aluno
    {
        //Campos
        private string nome;
        private int numeroMatricula;

        public string Nome { get => nome; set => nome = value; }
        public int NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;

        }

        //To String
        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula} ";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

    }
}
