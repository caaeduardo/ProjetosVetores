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
            Console.WriteLine("3. Números Repetidos: Crie um programa que leia um vetor de 10 números inteiros e verifique se existe algum número repetido.\n ");

            {
                Console.Write("Digite a nota (0 a 10): ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 6)
                {
                    Console.WriteLine("Aprovado");
                }
                else if (nota >= 4)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }  
        internal void Exe4() 
        {
            Console.WriteLine("4. Anagrama: Faça um programa que leia um vetor de 5 caracteres e verifique se ele é um anagrama de outra palavra.\n");

            { 
                Console.WriteLine("Digite seu peso (em Kg):\n "); 
                double peso = double.Parse(Console.ReadLine());
                Console.Write("Digite sua altura (em metros\n): ");
                double altura = double.Parse(Console.ReadLine());
                
                //double imc funcionou testei double peso = imc e deu errado
                double imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine("Você está abaixo do peso\n");
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    Console.WriteLine("Você está no peso adequado\n");
                }
                else if (imc >= 25 && imc <30)
                {
                    Console.WriteLine("Você está com sobrepeso\n");
                } 
                else
                {
                    Console.WriteLine("Você está com Obesidade\n");
                }
                Console.WriteLine("Fim do exercício 4");
                Console.WriteLine("-------------------------------------------------------------");

            }

        }
        internal void Exe5() 
        {
            Console.WriteLine("5. Inversão: Crie um programa que leia um vetor de 10 números inteiros e inverta a ordem dos elementos.\n");
            {
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine();


                if (num1 > num2)
                {
                    Console.WriteLine("O maior número é: " + num1);
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("O maior número é: " + num2);

                }
                else
                {
                    Console.WriteLine("Os números são iguais.");
                }
            }

        }


        internal void Exe6() 
        {
            Console.WriteLine("6. Números Pares: Faça um programa que leia um vetor de 5 números inteiros e crie um novo vetor com os números pares.\n");

            
        }
        internal void Exe7() 
        {
            Console.WriteLine("7. Inversão: Crie um programa que leia um vetor de 10 números inteiros e inverta a ordem dos elementos.\n");
        }
        internal void Exe8() 
        {
            Console.WriteLine("8. Inversão: Crie um programa que leia um vetor de 10 números inteiros e inverta a ordem dos elementos.\n");
        }
        internal void Exe9() 
        {
            Console.WriteLine("9. Inversão: Crie um programa que leia um vetor de 10 números inteiros e inverta a ordem dos elementos.\n");
        }
        internal void Exe10() 
        { 
        
        }
    }
}
