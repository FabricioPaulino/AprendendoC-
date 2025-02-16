﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.5;
        }

    }
}
