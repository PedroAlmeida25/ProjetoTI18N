using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Control
    {
        Calculadora calc;//Conectando a variável calc a classe Calculadora
        private int opcao;
        public Control()
        {
            calc = new Calculadora();//Instanciando, calc é um objeto de calculadora
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }   
        }//Fim do método

        //Coletar
        public void ColetarNum1()
        {
            Console.WriteLine("Informe um número: ");
            calc.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum1

        public void ColetarNum2()
        {
            Console.WriteLine("Informe outro número: ");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim do método ColetarNum2

        public void Menu()
        {
            Console.WriteLine("------ Menu ------ " +
                              "\n0. Sair"           +
                              "\n1. Somar"          +
                              "\n2. Subtrair"       + 
                              "\n3. Dividir"        +
                              "\n4. Multiplicar"    +
                              "\n\n Escolha uma das opções acima: ");
           ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
         }//Fim do método Menu

        //Método que faça a operação
        public void operacao()
        {
            
            Menu();
            Console.Clear();//Limpa tela
            switch (ConsultarOpcao)
            {
                case 0:
                    Console.WriteLine("Obrigado!");
                    break;
                case 1:
                    ColetarNum1();//Pegando o primeiro número
                    ColetarNum2();//Pegando o segundo número
                    Console.WriteLine("A soma dos números digitados é: " + calc.Somar());
                    break;
                case 2:
                    ColetarNum1();
                    ColetarNum2();
                    Console.WriteLine("A subtração dos números digitados é: " + calc.Subtrair());
                    break;
                case 3:
                    ColetarNum1();
                    ColetarNum2();
                    if (calc.Dividir() <= -1)
                    {
                        Console.WriteLine("Impossível dividir!");
                    }
                    else
                    {
                        Console.WriteLine("A divisão dos números digitados é: " + calc.Dividir());
                        break;
                    }
                case 4:
                    ColetarNum1();
                    ColetarNum2();
                    Console.WriteLine("A multilicação dos números digitados é: " + calc.Multiplicar());
                    break;
                default:
                    Console.WriteLine("Opção escolhida não é válida, tente novamente!");
                    break;
            }//Fim do Switch    
        }while (ConsultarOpcao != 0);
	{

	}
        }//Fim do operacao
    }//Fim da classe
}//Fim do projeto
