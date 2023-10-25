using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaDeRepeticaoVetor
{
    class Control
    {
        Model modelo;
        private int opcao;

        public Control()
        {
            this.modelo = new Model();//Criando uma chave
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//Fim do método

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair \n" +
                              "1. Média de notas 10 alunos \n" +
                              "2. Vetor Inverso \n" +
                              "3. Mostrar os números pares do vetor \n" +
                              "4. Média de 20 valores \n" +
                              "5. \n" +
                              "6. \n" +
                              "7. \n" +
                              "8. \n" +
                              "9. \n" +
                              "10. \n" +
                              "11. \n" );
            opcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            do {
            Menu();//Mostrar menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                        break;
                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        this.modelo.NumerosPares();
                        this.modelo.MostrarVetor3();
                        break;
                    case 4:
                        Console.WriteLine(this.modelo.MediaVinte());
                        break;
                    default:
                        Console.WriteLine("ERRO! Escolha uma opção válida.");
                        break;
                
                }//Fim do Switch
            } while (ConsultarOpcao != 0);
        }//Fim do método Operacao

    }//Fim da classe
}//Fim do Projeto
