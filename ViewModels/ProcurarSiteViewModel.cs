using System.ComponentModel.DataAnnotations;

namespace SalvadorDeSenhas.ViewModels;

public class ProcurarSiteViewModel
{
    [Required(ErrorMessage = "O nome do site é obrigatório.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve conter entre 2 e 50 caracteres.")]
    public string NomeDoSite { get; private set; }

    public ProcurarSiteViewModel(string nomeDoSite)
    {
        NomeDoSite = nomeDoSite;
    }
}
