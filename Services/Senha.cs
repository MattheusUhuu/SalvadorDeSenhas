namespace SalvadorDeSenhas.Services;

public static class Senha
{
    public static string GerarSenha(byte digitos, string tipoCaracteres)
    {
        var senha = "";
        var caracteres = tipoCaracteres += "01234567890123456789";
        var tamanho = caracteres.Length;
        Random random = new Random();

        for (int i = 0; i < digitos; i++)
            senha += caracteres[random.Next(tamanho)];

        return senha;
    }
}
