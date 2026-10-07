namespace Portfolio.App.MiniProjetos.VerificadorIdade;

public class VerificadorIdadeProjeto : IMiniProjeto
{
    private readonly VerificadorIdadeService _servico = new();

    public string Nome => "Verificador de Idade";
    public string Descricao => "Informa uma idade e confirma se é maior de 18 anos.";
    public string[] Technologies => ["C#", "Console"];

    public void Executar()
    {
        Console.Clear();
        Console.Write("Informe sua idade: ");

        if (!int.TryParse(Console.ReadLine(), out int idade) || idade < 0)
        {
            Console.WriteLine("Idade inválida.");
            return;
        }

        bool maior = _servico.EhMaiorDeIdade(idade);
        Console.WriteLine(maior ? "Você é maior de 18 anos." : "Você é menor de 18 anos.");
    }
}
