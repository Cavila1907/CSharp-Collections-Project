using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Class_Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string aula1 = "Aula de História";
            string aula2 = "Aula de Educação Física";
            string aula3 = "Aula de Química";
            string aula4 = "Aula de Matematica";


            List<string> aulas = new List<string>();
            aulas.Add(aula1);
            aulas.Add(aula2);
            aulas.Add(aula3);
            aulas.Add(aula4);

            Imprimir(aulas);

            Console.WriteLine("");

            //Qual é a primeira aula?
            Console.WriteLine("Qual é a primeira aula da grade de 2022? ");
            Console.WriteLine($"A primeira aula da grade é: {aulas.First()}.");

            //Qual é a última aula?
            Console.WriteLine("Qual é a última aula da grade de 2022? ");
            Console.WriteLine($"A última aula da grade é: {aulas.Last()}.");

            Console.WriteLine("");

            //Após mudanças no planejamento, a aula 1 sofreu mudanças
            aulas[0] = "Aula de Programação";
            Console.WriteLine("Após mudanças no planejamento, a nova grade de aulas é: ");
            Imprimir(aulas);

            Console.WriteLine("");

            //Após a professora de quimíca pegar licença maternidade, a grade sofreu alterações
            aulas.Remove(aula3);
            Console.WriteLine("Após a professora de Química sair de licença maternidade: ");
            Imprimir(aulas);

            Console.WriteLine("");

            //Revertendo as aulas
            Console.WriteLine("Revertendo aulas:");
            aulas.Reverse();
            Imprimir(aulas);

            Console.WriteLine("");

            //Ordenando as aulas Alfabeticamente
            Console.WriteLine("Ordenando alfabeticamente:");
            aulas.Sort();
            Imprimir(aulas);

            Console.WriteLine("");

            //Adicionando item no meio da Lista
            aulas.Add("Aula de Filosofia");
            Imprimir(aulas);

            Console.WriteLine("");

            //Removendo um item específico
            aulas.RemoveAt(aulas.Count - 2);
            Imprimir(aulas);

            Console.WriteLine("");

            //Copiando o elemento da ultima posição
            List<string> copia = new List<string>(aulas);
            copia = aulas.GetRange(aulas.Count - 1, 1);
            Imprimir(copia);

            Console.WriteLine("");


            //Copiando o elemento da posição 2
            List<string> copia2 = new List<string>(aulas);
            copia2 = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia2);

            Console.WriteLine("");

            //Clonando 
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);










        }


        private static void Imprimir(List<string> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

    }
}
