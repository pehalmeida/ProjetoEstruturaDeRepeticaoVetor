using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaDeRepeticaoVetor
{
    class Model
    {
        public double[] notas;//Declaração de um Vetor
        public int i;
        private double soma;
        public int[] vetor;
        public int[] vetor3;
        public double[] vetor4;
        public int[] vetor5;
        public int contVetor5;
        public double[] vetor6;
        public double maior6 = 0;
        public double[] vetor7;
        public double menor7;
        public int posicao6;
        public double posicao7;
        public Model()
        {
            notas = new double[10];
            vetor = new int[5];
            vetor3 = new int[10];
            vetor4 = new double[20];
            vetor5 = new int[15];
            vetor6 = new double[25];
            vetor7 = new double[30];

            i = 0;
            ConsultarSoma = 0;
        }//Fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { soma = value; }
        }//Fim do get set

        //Exercício 01 - Guardar 10 notas de alunos diferentes
        public double MediaNotas()
        {
            for(i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    ConsultarSoma += notas[i];
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10!");
                    }//Fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
            }//Fim do for
            return ConsultarSoma / i;
        }//Fim do método

        //Exercício 02 - Ler um vetor de 5 elementos e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for(i=0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }//Fim do for
        }//FIm do método Preencher Vetor

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for(i = 4; i >= 0;i--)
            {
                Console.WriteLine(i+1 + "ª Posição: " + vetor[i]);
            }//Fim do for
        }//Fim do Mostrar Vetor

        //Exercício 03 - Mostrar apenas números pares do vetor
        public void NumerosPares()
        {
            for(i=0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Posição: ");
                    vetor3[i] = Convert.ToInt32(Console.ReadLine());
                    if (vetor3[i] < 0)
                    {
                        Console.WriteLine("Digite um número positivo");
                    }//Fim da validação
                } while (vetor3[i] < 0);
            }//Fim do for
        }//Fim do método Numeros Pares

        //Mostrar Vetor
        public void MostrarVetor3()
        {
            for (i=0; i < 10; i++)
            {
                if ((vetor3[i] % 2) == 0)
                {
                    Console.WriteLine(vetor3[i] + " è um número PAR");
                }//Fim do if
            }//Fim do for
        }//Fim do Mostrar Vetor

        //Exercício 04 - Calcular a média dos valores
        public double MediaVinte()
        {
            for(i = 0; i < 20; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Posição: ");
                    vetor4[i] = Convert.ToDouble(Console.ReadLine());
                    ConsultarSoma += vetor4[i];
                    if (vetor4[i] < 0)
                    {
                        Console.WriteLine("Digite um número positivo");
                    }//Fim da validação
                } while (vetor4[i] < 0);
            }//Fim do for
            Console.WriteLine("A média dos valores é: ");
            return ConsultarSoma / i;
        }//Fim do método Media Vinte

        //Exercício 05 - Quantidade de números pares
        public void ContPares()
        {
            for (i = 0; i < 15; i++)
            {
                do {
                    Console.WriteLine(i + 1 + "° número: ");
                    vetor5[i] = Convert.ToInt32(Console.ReadLine());
                    if (vetor5[i] < 0)
                    {
                        Console.WriteLine("Digite um núemro positivo!");
                    }//Fim da validação
                } while (vetor5[i] < 0);
            }//Fim do for
        }//Fim do método ContPares

        //Mostrar Vetor
        public void MostrarVetor5()
        {
            for (i = 0; i < 15; i++)
            {
                if ((vetor5[i] % 2) == 0)
                {
                    contVetor5 += 1;
                }
            }//Fim do for
            Console.WriteLine("\nTotal de números pares: " + contVetor5);
        }//Fim do método Mostrar Vetor5

        //Exercício 06 - Mostrar o maior valor
        public void MaiorValor()
        {
            for(i = 0; i < 25; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "º Valor: ");
                    vetor6[i] = Convert.ToDouble(Console.ReadLine());
                    if (vetor[i] < 0)
                    {
                        Console.WriteLine("Digite um valor positivo!");
                    }
                } while (vetor[i] < 0); //Fim do Validar

                    if (vetor6[i] > maior6)
                    {
                        maior6 = vetor6[i];
                        posicao6 = i + 1;
                    }
            }//Fim do for
            Console.WriteLine("\nO maior valor é: " + maior6 + " e a sua posição é: " + posicao6);
        }//Fim do método Mostrar Maior

        //Exercício 07 - Mostrar o Menor Valor
        public void MenorValor()
        {
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + "º Valor: ");
                vetor7[i] = Convert.ToDouble(Console.ReadLine());
            }//Fim do for
            menor7 = vetor7[0];
            for (i = 1; i < 3; i++)
            {
                if (vetor7[i] < menor7) 
                {
                    menor7 = vetor7[i];
                    posicao7 = i + 1;
                }
                else
                {
                    posicao7 = 1;
                }
            }//Fim do for
            Console.WriteLine("O menor valor é: " + menor7 + " e a sua posição é: " + posicao7 + "°");
        }//Fim do método Menor Valor

        //Exercício 08 - Encontrar o segundo maior valor

        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//Fim do Validar
    }//Fim da classe
}//Fim do Projeto
