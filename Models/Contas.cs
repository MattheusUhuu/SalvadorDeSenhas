using System.ComponentModel.DataAnnotations;

namespace SalvadorDeSenhas.Models;

public class Contas
{
    [Required(ErrorMessage = "O nome do site é obrigátorio.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve conter entre 2 e 50 caracteres.")]
    public string NomeDoSite { get; private set; }

    [Required(ErrorMessage = "A URL é obrigatória.")]
    public string UrlDoSite { get; private set; }

    [Required(ErrorMessage = "A senha é obrigatoria.")]
    [StringLength(25, MinimumLength = 3, ErrorMessage = "A senha deve conter entre 3 a 25 caracteres.")]
    public string Senha { get; private set; }

    public Contas() { }

    public Contas(string nomeDoSite)
    {
        NomeDoSite = nomeDoSite;
    }

    public Contas(string nomeDoSite, string urlDoSite, string senha)
    {
        NomeDoSite = nomeDoSite;
        UrlDoSite = urlDoSite;
        Senha = senha;
    }

    public Contas CadastrarSite(Contas contas)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(Global.ArquivoTxt))
            {
                sw.Write(contas.NomeDoSite.ToUpper() + ";");
                sw.Write(contas.UrlDoSite.ToUpper() + ";");
                sw.Write(contas.Senha);

                return contas;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public Contas ProcurarSite(string nomeDeBusca)
    {
        try
        {
            string[] linhas = File.ReadAllLines(Global.ArquivoTxt);
            Contas conta = new Contas();

            foreach (string line in linhas)
            {
                string[] campo = line.Split(';');

                if (nomeDeBusca.ToUpper().Equals(campo[0]))
                {
                    conta.NomeDoSite = campo[0];
                    conta.UrlDoSite = campo[1];
                    conta.Senha = campo[2];
                }
            }

            return conta;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void AtualizarSenha(string nomeDeBusca, string novaSenha)
    {
        try
        {
            string[] linhas = File.ReadAllLines(Global.ArquivoTxt);
            List<string> contasDoSite = new List<string>();

            foreach (string line in linhas)
            {
                string[] campo = line.Split(';');
                
                if (nomeDeBusca.ToUpper().Equals(campo[0]))
                {
                    contasDoSite.Add(line.Replace(campo[2], novaSenha));
                }
                else
                {
                    contasDoSite.Add(line);
                }
            }

            File.WriteAllLines(Global.ArquivoTxt, contasDoSite);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
