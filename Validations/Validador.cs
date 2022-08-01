using System.ComponentModel.DataAnnotations;

namespace SalvadorDeSenhas.Validations;

public class Validador
{
    private static List<string> ErrorMessages;

    public static bool IsValid<T>(object obj)
    {
        var validacao = new List<ValidationResult>();
        var contexto = new ValidationContext(obj, null, null);

        if (Validator.TryValidateObject(obj, contexto, validacao, true))
            return true;

        ErrorMessages = new List<string>();
        ErrorMessages.AddRange(validacao.Select(x => x.ErrorMessage).ToList());

        return false;
    }

    public static void GetErrors()
    {
        string camposInvalidos = "";
        foreach (var erro in ErrorMessages)
            camposInvalidos += erro + "\n";

        MessageBox.Show(camposInvalidos);
    }
}
