using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosVetores
{
    internal class Lista1
    {
        internal void Exe1()
        {
            Console.WriteLine("1. Média Aritmética: Crie um programa que leia um vetor de 10 números reais e calcule a média aritmética.\n");

            {
                double[] numeros = new double[10];
                double soma = 0;

                Console.WriteLine("Digite 10 números reais:");
                for (int i = 0; i < 10; i++)
                {
                    numeros[i] = double.Parse(Console.ReadLine());
                    soma += numeros[i];
                }

                double media = soma / 10;
                Console.WriteLine("A média aritmética é: " + media);


            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe2()
        {
            Console.WriteLine("2. Ordenação Alfabética: Faça um programa que leia um vetor de 5 nomes e os imprima em ordem alfabética.\n");

            {

                string[]  nomes = new string[5];
                Console.WriteLine("Digite 5 nomes: ");
                for
                    (int i = 0;i < 5;i++)
                {
                    nomes[i] = Console.ReadLine();
                }
                Array.Sort(nomes);
                Console.WriteLine();
                foreach 
                    (string nome in nomes)
                {
                    Console.WriteLine(nome);
                }

            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");

        }

        internal void Exe3()
        {
            Console.WriteLine("3. 3. Números Repetidos: Crie um programa que leia um vetor de 10 números inteiros e verifique se existe algum número repetido.\n ");

            {


            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
            
        internal void Exe4() { }
        internal void Exe5() { }
        internal void Exe6() { }
        internal void Exe7() { }
        internal void Exe8() { }
        internal void Exe9() { }
        internal void Exe10() { }
    }
}
