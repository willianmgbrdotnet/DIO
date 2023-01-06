//Informar o numero digitado e sair da repeticao quando o usuario digitar 0
using System;

namespace Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            while(condicao == true)
            {
                Console.WriteLine("Digite um valor, 0 para sair");

                valor = int.Parse(Console.ReadLine());

                Console.WriteLine("o numero digitado foi, " + valor);

                if(valor == 0)
                {
                    Console.WriteLine("Você saiu da repeticao");

                    condicao = false;
                }             
            }
        }
    }
}