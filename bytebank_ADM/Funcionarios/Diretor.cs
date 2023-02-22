using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000) //invocando método construtor da classe base que exige o parâmetro cpf
        {
            //Console.WriteLine("Criando um diretor.");
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
    }
}
