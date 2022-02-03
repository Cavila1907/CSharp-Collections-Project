using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new Carro("Vectra 1.0", 20);
            var carro2 = new Carro("Gol 2.0", 19);
            var carro3 = new Carro("Uno 1.5", 21);
            var carro4 = new Carro("Gurgel 1.8", 12);

            List<Carro> carros = new List<Carro>();
            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);
            carros.Add(carro4);


            //Imprimindo 
            Console.WriteLine("Seja bem-vindo ao sistema de controle da concessionária:");
            Imprimir(carros);

            Console.WriteLine("");

            //Imprimindo a primeira posição
            Console.WriteLine("O primeiro a carro a ser testado foi: ");
            Console.WriteLine(carros.First());

            Console.WriteLine("");

            //Imprimindo após ordenar alfabeticamente
            carros.Sort();
            Imprimir(carros);

            Console.WriteLine("");

            //Imprimindo após ordernar por tempo
            carros.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(carros);

            Console.WriteLine("");

            //Revertendo 
            carros.Reverse();
            Imprimir(carros);

            Console.WriteLine("");

            //Uma cópia
            List<Carro> copia = new List<Carro>();
            copia = carros.GetRange(carros.Count - 2, 2);
            Imprimir(copia);

            Console.WriteLine("");

            //Um clone
            List<Carro> clone = new List<Carro>(carros);
            Imprimir(clone);

        }

        private static void Imprimir(List<Carro> carros)
        {
            foreach (var carro in carros)
            {
                Console.WriteLine(carro);
            }
        }

        class Carro : IComparable
        {
            //Campos
            private string modelo;
            private int tempo;

            

            //Propriedades
            public string Modelo { get => modelo; set => modelo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            //Construtor
            public Carro(string modelo, int tempo)
            {
                this.modelo = modelo;
                this.tempo = tempo;
            }

            public int CompareTo(object obj)
            {
                Carro that = obj as Carro;
                return this.modelo.CompareTo(that.modelo);
            }

            //Sobre sai o metodo do object
            public override string ToString()
            {
                return $"[Modelo: {modelo}, tempo: {tempo} minutos]";
            }

            
        }

    }
}
