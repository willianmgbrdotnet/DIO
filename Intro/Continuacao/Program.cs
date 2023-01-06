//uso do comando break e continue
using System;

namespace Continuacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            do
            {
                Console.WriteLine("Digite um valor, 0 para sair");

                valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    Console.WriteLine("Você saiu da repeticao");

                    break;

                    //condicao = false;
                }
                else
                {
                Console.WriteLine("o numero digitado foi, " + valor);
                
                }                     
                  
            }
            //dois sinais de igual quando definir o valor real da variavel
            while(condicao == true);

        }
    }
}