using System;
using System.Collections.Generic;
using System.Linq;
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
        public Model()
        {
            notas = new double[10];
            vetor = new int[5];
            vetor3 = new int[10];
            vetor4 = new double[20];
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
            return ConsultarSoma / i + 1;
        }//Fim do método Media Vinte

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
