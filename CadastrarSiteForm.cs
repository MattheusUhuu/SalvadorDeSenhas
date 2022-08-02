using SalvadorDeSenhas.Models;
using SalvadorDeSenhas.PedroControls;
using SalvadorDeSenhas.Services;
using SalvadorDeSenhas.Validations;

namespace SalvadorDeSenhas;

public partial class CadastrarSiteForm : Form
{
    public CadastrarSiteForm()
    {
        InitializeComponent();
    }

    private void btnCadastrar_DoFormCadastrar_Click(object sender, EventArgs e)
    {
        PedroTextBox pedroTextBox = new PedroTextBox();

        Contas conta = new Contas(txtNomeDeCadastro.Texts, txtUrlCadastro.Texts, txtSenhaCadastro.Texts);

        if (!Validador.IsValid<Contas>(conta))
        {
            Validador.GetErrors();
            return;
        }

        conta.CadastrarSite(conta);
        txtNomeDeCadastro.Clear();
        txtSenhaCadastro.Clear();
        txtUrlCadastro.Clear();
        txtNomeDeCadastro.Focus();
        MessageBox.Show("Site cadastrado com sucesso");
    }

    private void btnGerarSenha_DoFormCadastrar_Click(object sender, EventArgs e)
    {
        string caracteres = "";

        if (checkBoxCaracteresEspeciais_FormCadastrar.Checked)
            caracteres += checkBoxCaracteresEspeciais_FormCadastrar.Tag;

        if (checkBoxMaiusculas_FormCadastrar.Checked)
            caracteres += checkBoxMaiusculas_FormCadastrar.Tag;

        if (checkBoxMinusculas_FormCadastrar.Checked)
            caracteres += checkBoxMinusculas_FormCadastrar.Tag;

        txtSenhaCadastro.Focus();
        txtSenhaCadastro.Texts = Senha.GerarSenha(10, caracteres);
    }
}
