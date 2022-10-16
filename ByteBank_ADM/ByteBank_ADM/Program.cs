using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitarios;

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro alvares";

    Diretor paula = new Diretor("159.343.532-99");
    pedro.Nome = "Paula mascato";

    Auxiliar igor = new Auxiliar("901.693.456-00");
    igor.Nome = "Igor Silva";

    GerenteDeContas camila = new GerenteDeContas("123.789.573-55");
    camila.Nome = "Camila Prado";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao);
}

CalcularBonificacao();
