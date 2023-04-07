using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR5Kaua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("Pressione 1 para exercício 1");
            Console.WriteLine("Pressione 2 para exercício 2");
            Console.WriteLine("Pressione 3 para exercício 3");
            Console.WriteLine("Pressione 4 para exercício 4");
            Console.WriteLine("Pressione 5 para exercício 5");
            Console.WriteLine("Pressione 6 para exercício 6");
            Console.WriteLine("Pressione 7 para exercício 7");
            Console.WriteLine("Pressione 8 para sair");
            Console.WriteLine("==============================\n");

            Console.WriteLine("Escolha o exercício");
            int exercicio = int.Parse(Console.ReadLine());


            for (; exercicio != 8;)
            {
                switch (exercicio)
                {
                    case 1:

                        Console.WriteLine("\nInforme um número:");
                        int ns1 = int.Parse(Console.ReadLine());

                        for (int i = 1; i < ns1 + 1; i++)
                        {
                            Console.Write("{0} ", i);
                        }
                        break;

                    case 2:

                        Console.WriteLine("\nInforme um número");
                        int ns2 = int.Parse(Console.ReadLine());

                        for (int i = 1; i < ns2 + 1; i++)
                        {
                            if (i % 2 == 0)
                                Console.Write("{0} ", i);
                        }
                        break;

                    case 3:

                        Console.WriteLine("\nInforme um número");
                        int ns3 = int.Parse(Console.ReadLine());

                        if (ns3 >= 1000) Console.WriteLine("\nO número deve ser menor que 1000!");

                        for (int i = 1000; i > ns3 - 1; i--)
                        {
                            if (i % 2 == 0)
                                Console.Write("{0} ", i);
                        }
                        break;

                    case 4:

                        int somaNumeros = 0;
                        string numerosPositivos = "";

                        for (; somaNumeros < 200;)
                        {
                            Console.WriteLine("\nInforme um número");
                            int ns4 = int.Parse(Console.ReadLine());

                            if (ns4 > -1)
                            {
                                somaNumeros += ns4;
                                numerosPositivos += ns4 + " ";
                            }

                        }

                        Console.WriteLine("\nNúmeros positivos informados:\n{0}", numerosPositivos);
                        break;

                    case 5:

                        Console.WriteLine("\nInforme um número");
                        int ns5 = int.Parse(Console.ReadLine());
                        string divisores = "";

                        if (ns5 <= 0) { 
                        Console.WriteLine("Número inválido! Deve ser informado um número maior que 0.");
                        }   
                        for (int i = 1; i < ns5 + 1; i++)
                        {
                            if (ns5 % i == 0)
                                divisores += i + " ";
                        }

                        Console.WriteLine("\nOs divisores de {0} são: {1}", ns5, divisores);
                        break;
                   
                    case 6:

                        int menor = 0, maior = 0;

                        for (int i = 0; i < 11; i++)
                        {
                            Console.WriteLine("\nInforme um número");
                            int ns6 = int.Parse(Console.ReadLine());

                            if (i == 0)
                            {
                                menor = ns6;
                                maior = ns6;
                            }

                            else if (ns6 > maior) maior = ns6;
                            else if (ns6 < menor) menor = ns6;
                        }

                        Console.WriteLine("\nMenor número informado: {0}\nMaior número informado: {1}", menor, maior);
                        break;
                    
                    case 7:

                        int somaPares = 0, somaImpares = 0;

                        Console.WriteLine("\nInforme um número ou digite 0 para finalizar o programa.");
                        int ns7 = int.Parse(Console.ReadLine());

                        for (; ns7 != 0;)
                        {
                            if (ns7 % 2 == 0) somaPares += ns7;
                            else somaImpares += ns7;

                            Console.WriteLine("\nInforme um número ou digite 0 para finalizar o programa.");
                            ns7 = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\nSoma dos números pares: " + somaPares + "\nSoma do números ímpares: " + somaImpares );
                        break;

                        default: Console.WriteLine("Exercio invalido!");
                        break; 
                }
                Console.WriteLine("\n\n==========MENU==========");
                Console.WriteLine("Pressione 1 para exercício 1");
                Console.WriteLine("Pressione 2 para exercício 2");
                Console.WriteLine("Pressione 3 para exercício 3");
                Console.WriteLine("Pressione 4 para exercício 4");
                Console.WriteLine("Pressione 5 para exercício 5");
                Console.WriteLine("Pressione 6 para exercício 6");
                Console.WriteLine("Pressione 7 para exercício 7");
                Console.WriteLine("Pressione 8 para sair");
                Console.WriteLine("==============================\n");

                Console.WriteLine("Escolha o exercício");
                exercicio = int.Parse(Console.ReadLine());
            }
        }
    }
}




