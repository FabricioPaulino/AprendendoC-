using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 3000)
        {
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
