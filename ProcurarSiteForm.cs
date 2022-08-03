using SalvadorDeSenhas.Models;
using SalvadorDeSenhas.Validations;
using SalvadorDeSenhas.ViewModels;

namespace SalvadorDeSenhas;

public partial class ProcurarSiteForm : Form
{
    public ProcurarSiteForm()
    {
        InitializeComponent();
    }

    private void btnProcurar_DoFormProcurar_Click(object sender, EventArgs e)
    {
        Contas conta = new Contas(txtNome_DoProcurarForm.Texts);
        ProcurarSiteViewModel contaViewModel = new ProcurarSiteViewModel(txtNome_DoProcurarForm.Texts);

        if (!Validador.IsValid<ProcurarSiteViewModel>(contaViewModel))
        {
            Validador.GetErrors();
            return;
        }

        List<Contas> listaDeContas = new List<Contas>();
        listaDeContas.Add(conta.ProcurarSite(txtNome_DoProcurarForm.Texts));

        foreach (var contaDaLista in listaDeContas)
        {
            if (contaDaLista.NomeDoSite == null)
            {
                MessageBox.Show("Site não encontrado.");
                return;
            }

            listBox_DoProcurarForm.Items.Clear();
            listBox_DoProcurarForm.Items.Add($"Nome do site: {contaDaLista.NomeDoSite}");
            listBox_DoProcurarForm.Items.Add($"Url do site: {contaDaLista.UrlDoSite}");
            listBox_DoProcurarForm.Items.Add($"Senha do site: {contaDaLista.Senha}");
        }
        txtNome_DoProcurarForm.Clear();
    }
}
