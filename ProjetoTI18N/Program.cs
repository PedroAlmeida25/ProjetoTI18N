using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conectar o Console com a Control
            Control controle = new Control();//Declaro e instancio a variável
            controle.operacao();//Método Operação


            Console.ReadLine();//Leia - Uso para manter o prompt;
        }//Fim do método main
    }//Fim da classe Program
}//Fim do Projeto
