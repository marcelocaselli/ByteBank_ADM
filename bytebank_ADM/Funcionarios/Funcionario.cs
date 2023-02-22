using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public  static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++; //sempre que for criado um objeto funcionario ele conta +1
            //Console.WriteLine("Criando um funcionario.");
        }

        public abstract void AumentarSalario();
        

        
    }
}
