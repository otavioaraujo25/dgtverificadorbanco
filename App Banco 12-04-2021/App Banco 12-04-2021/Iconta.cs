using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancodobrasil
{
    class IConta
    {
       

        public Conta Valores()
        {
            int agencia, nroConta;
            try
            {
                
                Console.WriteLine("Digite o numero da Agência Com o Digito (Sem hífen): ");
                agencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero da Conta Com o Digito (Sem hífen): ");
                nroConta = int.Parse(Console.ReadLine());
                return new Conta(nroConta, agencia);
            }
            catch
            {
                Console.WriteLine("ERROR");
                return null;
            }
        }
    }
}