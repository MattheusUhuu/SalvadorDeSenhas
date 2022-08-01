namespace SalvadorDeSenhas;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // Cria uma pasta e um arquivo txt caso não exista um
        string arquivo = "";
        arquivo = Path.GetFullPath(Global.ArquivoTxt);

        FileStream fileInfo = null;
        try
        {
            if (!File.Exists(arquivo))
            {
                Directory.CreateDirectory(Global.Pasta);
                fileInfo = new FileStream(Global.ArquivoTxt, FileMode.CreateNew);
            }
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            if (fileInfo != null) fileInfo.Close();
        }

        CadastrarSiteForm cadastrarSite = new CadastrarSiteForm();
        cadastrarSite.TopLevel = false;
        cadastrarSite.Dock = DockStyle.Fill;
        panelCentral.Controls.Clear();
        panelCentral.Controls.Add(cadastrarSite);
        cadastrarSite.Show();
    }

    private void btnPainelCadastrarSite_Click(object sender, EventArgs e)
    {
        CadastrarSiteForm cadastrarSite = new CadastrarSiteForm();

        cadastrarSite.TopLevel = false;
        cadastrarSite.Dock = DockStyle.Fill;
        panelCentral.Controls.Clear();
        panelCentral.Controls.Add(cadastrarSite);
        cadastrarSite.Show();
    }

    private void btnPainelProcurarSite_Click(object sender, EventArgs e)
    {
        ProcurarSiteForm procurarSite = new ProcurarSiteForm();

        procurarSite.TopLevel = false;
        procurarSite.Dock = DockStyle.Fill;
        panelCentral.Controls.Clear();
        panelCentral.Controls.Add(procurarSite);
        procurarSite.Show();
    }

    private void btnPainelMudarSenha_Click(object sender, EventArgs e)
    {
        MudarSenhaForm mudarSenha = new MudarSenhaForm();

        mudarSenha.TopLevel = false;
        mudarSenha.Dock = DockStyle.Fill;
        panelCentral.Controls.Clear();
        panelCentral.Controls.Add(mudarSenha);
        mudarSenha.Show();
    }
}
