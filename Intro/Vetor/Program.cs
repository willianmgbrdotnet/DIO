//foreach arrays
using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] megasena = {48,27,37,02,58,09};

            //cada numero inteiro dentro da lista megasena sera atribuído à variável sorteados
            foreach(int sorteados in megasena)
            {
                //print cada numero da lista
                Console.WriteLine(sorteados);
            }

        }
    }
}