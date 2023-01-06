//Function Switch - return monthes
using System;

namespace Switch
{
class Program
{
    static void Main(String[] args)
    {
        int mes;

        Console.WriteLine("Digite um numero do mes");
        mes = int.Parse(Console.ReadLine());

        switch(mes)
        {
            case 1:
            Console.WriteLine("janeiro");
            break;
            
            case 2:
            Console.WriteLine("Fevereiro");
            break;

            case 3:
            Console.WriteLine("março");
            break;

            case 4:
            Console.WriteLine("abril");            
            break;

            default:
            Console.WriteLine("digite um mes valido");
            break;
        }

    }

}
}