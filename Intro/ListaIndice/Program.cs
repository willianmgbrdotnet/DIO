//Criar uma lista a partir do numero digitado
using System;

namespace ListaIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Digite o numero inicial da Lista");

            valor = int.Parse(Console.ReadLine());

//Apartir do numero inicial, enquanto indice for menor ou igual a 100, incrementar o indice.
            for(int i = valor; i <= 100; i++)
            {
                //exibe a lista a partir do indice inicial digitado pelo usuario
                Console.WriteLine(i);
            }
        }       

    }
}