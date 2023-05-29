using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscas
{
    public class Busca
    {
        static int quest()
        {
            Console.Write("Escreva um numero: ");
            return int.Parse(Console.ReadLine());
        }
        static void Prossiga(){
            Console.WriteLine("Aperte enter para Continuar...");
            Console.ReadLine();
        }

        static void Mostrar(int[] vetor)
        {
            foreach (int number in vetor)
            {
                Console.Write(number+", ");
            }
            Console.WriteLine();
        }

        public int[] inserirValor(int[] vetor)
        {
            int valor = quest(),
                index=0;
            int[] vetor2 = new int[ vetor.Length + 1];

            for(int i=0; i <= vetor.Length; i++)
            {
                if(valor < vetor[ i - ( i == vetor.Length ? 1 : 0 )])
                {
                    if(index == 0)
                    {
                        vetor2[i] = valor;
                        index++;
                        i++;
                    }
                    if (i < vetor2.Length)
                        vetor2[i] = vetor[i - 1];
                } 
                else if (valor > vetor[vetor.Length - 1])
                {                    
                    for(int n=0; n < vetor.Length; n++)
                    {
                        vetor2[n] = vetor[n];
                    }
                    vetor2[vetor.Length] = valor;
                    break;
                }
                else {  vetor2[i] = vetor[i];  }
            }
            Mostrar(vetor2);
            Prossiga();
            Console.Clear();
            return vetor2;
        }

        public void buscaBinaria(int[] vetor)
        {
            int valor = quest(),
                inicio = 0,
                indice = 0;
            List<int> vetor1 = vetor.ToList();
            while (true)
            {
                if (valor > vetor1[vetor1.Count / 2])
                {
                    indice += vetor1.Count / 2;
                    vetor1 = vetor1.GetRange(vetor1.Count / 2, vetor1.Count / 2);
                }
                else if (valor < vetor1[vetor1.Count / 2])
                {
                    
                    vetor1 = vetor1.GetRange(inicio, vetor1.Count / 2);
                    
                }
                else if(vetor1.Count == 2)
                {
                    Console.WriteLine(
                        $"O numero {valor} esta no indice { indice + (vetor1[0] == valor ? 0 : 1) } do vetor"
                    );
                    break;
                }
                else if (vetor1.Count == 1 && valor != vetor[vetor1.Count / 2])
                {
                    Console.WriteLine("Esse numero não existe dentro do vetor");
                    break;
                }
                else if (vetor1[vetor1.Count / 2] == valor)
                {
                    Console.WriteLine($"O numero {valor} esta no indice {indice + vetor1.Count / 2} do vetor");
                    break;
                }else if (vetor[indice] == valor)
                {
                    Console.WriteLine($"O numero {valor} esta no indice {indice} do vetor");
                    break;
                }
            }


            Prossiga();
            Console.Clear();
        }

        public void buscaSequencial(int[] vetor)
        {
            int valor = quest();
            for (int i = 0; i < vetor.Length; i++)
                if (valor == vetor[i])
                {
                    Console.WriteLine($"O numero {valor} esta no indice {i} do vetor");
                    break;
                }
                else if (i == vetor.Length - 1)
                {
                    Console.WriteLine("Esse numero não existe dentro do vetor");
                }
            Prossiga();
            Console.Clear();
        }
    }
}
