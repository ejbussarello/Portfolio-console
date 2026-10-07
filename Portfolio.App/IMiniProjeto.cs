namespace Portfolio.App;

public interface IMiniProjeto
{
    string Nome { get; }
    string Descricao { get; }
    string[] Technologies { get; }
    void Executar();
}
