using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_7.Classes
{
    class Aula
    {
        //Campos
        private string materia;
        private int tempo;

        public string Materia { get => materia; set => materia = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public Aula(string materia, int tempo)
        {
            this.materia = materia;
            this.tempo = tempo;
        }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.materia.CompareTo(that.materia);
        }

        //Sobre sai o metodo do object
        public override string ToString()
        {
            return $"[Matéria: {materia}, tempo: {tempo} minutos]";
        }

    }
}
