using System;

namespace Bancodobrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            IConta n1 = new IConta();
            Conta n2 =  n1.Valores();

            if (n2 == null)
            {
                Console.WriteLine("Dados incorretos!");
                Console.ReadKey();
            }
            else if (n2.nroConta == true && n2.agencia == true)
            {
                Console.WriteLine(n2.ToString());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O Digito Verificador Esta Incorreto!");
                Console.ReadKey();
            }
            
        }
    }
}