using Portfolio.App;
using Portfolio.App.MiniProjetos.VerificadorIdade;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Para adicionar um mini projeto novo, basta incluir uma linha aqui.
List<IMiniProjeto> projetos =
[
    new VerificadorIdadeProjeto(),
];

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== MEU PORTFÓLIO ===");

    for (int i = 0; i < projetos.Count; i++)
        Console.WriteLine($"{i + 1} - {projetos[i].Nome}: {projetos[i].Descricao}");

    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 0 || opcao > projetos.Count)
    {
        Console.WriteLine("Opção inválida.");
        continue;
    }

    if (opcao == 0)
        break;

    Console.WriteLine();
    projetos[opcao - 1].Executar();
}
