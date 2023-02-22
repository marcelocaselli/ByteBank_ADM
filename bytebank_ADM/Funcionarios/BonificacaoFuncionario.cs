using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class BonificacaoFuncionario : Funcionario, IBonificacao
    {
        protected BonificacaoFuncionario(string cpf, double salario) : base(cpf, salario)
        {
        }      
    }
}
