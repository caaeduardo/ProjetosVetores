using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosVetores
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string Consultar;
            do
            {

                menulistas();
                Console.WriteLine("Por gentileza, deseja continuar as atividades de Vetores??? (S/N):\n");
                Consultar = Console.ReadLine().ToUpper();


            }

            while (Consultar == "S");

        


        }

        private static void menulistas()//metodo


        {
            

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            int op = 0;
            Console.WriteLine("############# VETORES ##############\nCadu 1.2 Version MOD | Caaeduardo      ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1 - PRIMEIRA LISTA DOS VETORES");
            Console.WriteLine("0 - Para Fechar o Shell\n");

            Console.Write("Numero da LISTA: ");
            op = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");


            //Switch Case
            switch (op)
            {
                case 0:
                    // Use o comando abaixo para interromper o programa
                    Environment.Exit(0);
                    break;


                //LISTA 1

                case 1:   //Menu da primeira Lista de atividades1
                    Lista1 lista1 = new Lista1();
                    Console.Clear();
                    int opLista1 = 0;
                    Console.WriteLine("############# VETORES (LISTA 1) ##############");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Quarta  atividade");
                    Console.WriteLine("5 - Quinta  atividade");
                    Console.WriteLine("6 - Sexta  atividade");
                    Console.WriteLine("7 - Sétima  atividade");
                    Console.WriteLine("8 - Oitava  atividade");
                    Console.WriteLine("9 - Nona  atividade");
                    Console.WriteLine("10 - La Décima  atividade");
                    Console.WriteLine("Digite o numero da atividade: \n");
                    opLista1 = int.Parse(Console.ReadLine());

                    switch (opLista1)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe10();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
            }
        }
    
    }



}
