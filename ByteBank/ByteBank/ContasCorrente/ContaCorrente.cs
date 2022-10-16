using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titulares;

namespace ByteBank.ContasCorrente
{
    internal class ContaCorrente
    {
        public static int NumeroTotalDeContas { get; private set; }
        
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set { 
                    if(value > 0)
                    {
                        this.numero_agencia = value;
                    }
                     
            
                }
        }

        public string Conta { get; set; }
        public cliente Titular { get; set; }

        private string Nome_Agencia { get; set; }

        private double saldo = 100;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor < saldo)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;
        }


    }
}
