using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancodobrasil
{
    class Conta
    {
        public bool nroConta { get; set; }
        public bool agencia { get; set; }
        private string nomeCliente { get; set; }
        private string Saldo { get; set; }

        public Conta(int nroConta, int agencia)
        {
            this.nroConta = DivConta(nroConta);
            this.agencia = DivAgencia(agencia);
            this.nomeCliente = "Otávio Souza Araujo";
            this.Saldo = "R$1.000.000.000.000";
        }

        public bool DivConta(int nroConta)
        {
            string conta = "00";
            conta += nroConta.ToString();
            int[] Peso = { 9, 8, 7, 6, 5, 4, 3, 2 };
            int digito = 0;
            for (int i = 0; i < Peso.Length; i++)
            {
                int aux2 = (int)Char.GetNumericValue(conta[i]);
                int aux = aux2 * Peso[i];
                digito += aux;
            }
            digito %= 11;
            digito = 11 - digito;
            int aux3 = (int)Char.GetNumericValue(conta[8]);
            if (digito == aux3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DivAgencia(int agencia)
        {
            string conta = agencia.ToString();
            int[] Peso = { 5, 4, 3, 2 };
            int digito = 0;
            for (int i = 0; i < Peso.Length; i++)
            {
                int aux2 = (int)Char.GetNumericValue(conta[i]);
                int aux = aux2 * Peso[i];
                digito += aux;
            }
            digito %= 11;
            digito = 11 - digito;
            int aux3 = (int)Char.GetNumericValue(conta[4]);
            if (digito == aux3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Nome da conta: "
                + nomeCliente
                + "\n"
                + "Saldo da Conta: "
                + Saldo
                + "\n"
                + "O Código Verificador Esta Correto!";
        }
    }
}
 