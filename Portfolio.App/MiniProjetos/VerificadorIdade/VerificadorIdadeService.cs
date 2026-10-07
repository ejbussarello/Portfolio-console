namespace Portfolio.App.MiniProjetos.VerificadorIdade;

public class VerificadorIdadeService
{
    public bool EhMaiorDeIdade(int idade)
    {
        if (idade < 0)
            throw new ArgumentOutOfRangeException(nameof(idade), "A idade não pode ser negativa.");

        return idade >= 18;
    }
}
