namespace SalvadorDeSenhas;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        CadastrarSiteForm cadastrarSite = new CadastrarSiteForm();
        cadastrarSite.TopLevel = false;
        cadastrarSite.Dock = DockStyle.Fill;
        panelCentral.Controls.Clear();
        panelCentral.Controls.Add(cadastrarSite);
        cadastrarSite.Show();
    }
}
