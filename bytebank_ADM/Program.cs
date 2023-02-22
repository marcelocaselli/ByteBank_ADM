using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using System.Net.Http.Headers;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);


//Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário de Pedro: " + pedro.Salario);
//Console.WriteLine("Novo salário de Roberta: " + roberta.Salario);
#endregion

//CalcularBonificacao();

UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("123456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("654321");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("98765");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);

    
}


void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("826489");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    
    GerenteDeContas ursula = new GerenteDeContas("34567");
    ursula.Nome = "Ursula Alcantar";
    ursula.Senha = "321";
    
    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "876";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "321");
    sistema.Logar(caio, "876");
 




}

