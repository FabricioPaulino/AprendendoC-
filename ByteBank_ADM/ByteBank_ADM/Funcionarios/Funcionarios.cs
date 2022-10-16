using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 Funcionarios
        // 1 Diretor
        // 2 analista
        // N...
        //private int _tipo;
        
        //public Funcionarios(int _tipo)
        //{
        //    this._tipo = _tipo;
        //}

        public string Nome { get; set; }

        public string Cpf { get; private set; }
         
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um funcionario.");
            TotalDeFuncionarios++;
        }

        //public Funcionarios(string nome, string cpf, double valor)
        //{
        //    Nome = nome;
        //    Cpf = cpf;
        //    Salario = valor;
        //}

        public virtual double getBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    
    }
}
