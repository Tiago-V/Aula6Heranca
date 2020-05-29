using System;

namespace Atv_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();

            Console.WriteLine("Digite seu nome: ");
            cpf.nome = Console.ReadLine();
            Console.WriteLine( cpf.Saudacao());
        }
    }
}
