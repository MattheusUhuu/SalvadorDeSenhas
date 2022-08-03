using SalvadorDeSenhas.Models;
using SalvadorDeSenhas.Services;
using SalvadorDeSenhas.Validations;
using SalvadorDeSenhas.ViewModels;

namespace SalvadorDeSenhas;

public partial class MudarSenhaForm : Form
{
    public MudarSenhaForm()
    {
        InitializeComponent();
        txtNome_DoAlterarSenhaForm.Focus();
    }

    private void checkBoxMostrarSenhas_DoFormMudarSenha_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxMostrarSenhas_DoFormMudarSenha.Checked)
        {
            txtNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
            txtConfirmarNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
        }
        else
        {
            txtNovaSenha_DoAlterarSenhaForm.PasswordChar = true;
            txtConfirmarNovaSenha_DoAlterarSenhaForm.PasswordChar = true;
        }
    }

    private void btnAlterarSenha_Click(object sender, EventArgs e)
    {
        try
        {
            Contas conta = new Contas();
            ProcurarSiteViewModel procurarSite = new ProcurarSiteViewModel(txtNome_DoAlterarSenhaForm.Texts);

            if (!Validador.IsValid<ProcurarSiteViewModel>(procurarSite))
            {
                Validador.GetErrors();
                return;
            }

            if (txtNovaSenha_DoAlterarSenhaForm.Texts == txtConfirmarNovaSenha_DoAlterarSenhaForm.Texts && txtNovaSenha_DoAlterarSenhaForm.Texts.Any() && txtConfirmarNovaSenha_DoAlterarSenhaForm.Texts.Any())
            {
                MessageBox.Show("Senha alterada!");
                conta.AtualizarSenha(txtNome_DoAlterarSenhaForm.Texts, txtNovaSenha_DoAlterarSenhaForm.Texts);
                txtNome_DoAlterarSenhaForm.Clear();
                txtNovaSenha_DoAlterarSenhaForm.Clear();
                txtConfirmarNovaSenha_DoAlterarSenhaForm.Clear();
                txtNovaSenha_DoAlterarSenhaForm.Enabled = false;
                txtConfirmarNovaSenha_DoAlterarSenhaForm.Enabled = false;
                btnAlterarSenha.Enabled = false;
            }
            else
            {
                MessageBox.Show("As senhas estão diferentes.");
                txtNovaSenha_DoAlterarSenhaForm.Focus();
            }
        }
        catch (Exception erro)
        {
            MessageBox.Show("Ops, ouve algum erro!", erro.Message);
        }
    }

    private void btnGerarSenha_DoAlterarSenhaForm_Click(object sender, EventArgs e)
    {
        try
        {
            Contas conta = new Contas();
            var contaDoSite = conta.ProcurarSite(txtNome_DoAlterarSenhaForm.Texts.ToUpper());

            if (checkBoxMostrarSenhas_DoFormMudarSenha.Checked)
            {
                txtNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
                txtConfirmarNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
            }
            else
            {
                txtNovaSenha_DoAlterarSenhaForm.PasswordChar = true;
                txtConfirmarNovaSenha_DoAlterarSenhaForm.PasswordChar = true;
            }

            if (txtNome_DoAlterarSenhaForm.Texts.ToUpper() == contaDoSite.NomeDoSite && txtNome_DoAlterarSenhaForm.Texts.Any())
            {
                DialogResult respostaDoDialogo = new DialogResult();
                respostaDoDialogo = MessageBox.Show("Site encontrado! Deseja gerar a senha?", "Alterar senha.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respostaDoDialogo == DialogResult.Yes)
                {
                    string caracteres = "";
                    if (checkBoxCaracteresEspeciais_doAlterarSenhaForm.Checked)
                        caracteres += checkBoxCaracteresEspeciais_doAlterarSenhaForm.Tag;

                    if (checkBoxMaiusculas_DoAlterarSenhaForm.Checked)
                        caracteres += checkBoxMaiusculas_DoAlterarSenhaForm.Tag;

                    if (checkBoxMinusculas_DoAlterarSenhaForm.Checked)
                        caracteres += checkBoxMinusculas_DoAlterarSenhaForm.Tag;

                    txtNovaSenha_DoAlterarSenhaForm.Enabled = true;
                    txtNovaSenha_DoAlterarSenhaForm.Focus();
                    txtNovaSenha_DoAlterarSenhaForm.Texts = Senha.GerarSenha(10, caracteres);

                    txtConfirmarNovaSenha_DoAlterarSenhaForm.Enabled = true;
                    txtConfirmarNovaSenha_DoAlterarSenhaForm.Focus();
                    txtConfirmarNovaSenha_DoAlterarSenhaForm.Texts = txtNovaSenha_DoAlterarSenhaForm.Texts;
                }

                txtNovaSenha_DoAlterarSenhaForm.Enabled = true;
                txtConfirmarNovaSenha_DoAlterarSenhaForm.Enabled = true;
                btnAlterarSenha.Enabled = true;
                txtNovaSenha_DoAlterarSenhaForm.Focus();
            }
            else
            {
                MessageBox.Show("Site não encontrado!");
                txtNome_DoAlterarSenhaForm.Focus();
            }
        }
        catch (Exception message)
        {
            MessageBox.Show("Site não encontrado!", message.Message);
        }
    }
}
