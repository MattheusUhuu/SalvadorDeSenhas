namespace SalvadorDeSenhas;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPainelMudarSenha = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.btnPainelProcurarSite = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.btnPainelCadastrarSite = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(922, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salvador de Senhas em .txt";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(13)))), ((int)(((byte)(117)))));
            this.panelLeft.Controls.Add(this.btnPainelMudarSenha);
            this.panelLeft.Controls.Add(this.btnPainelProcurarSite);
            this.panelLeft.Controls.Add(this.btnPainelCadastrarSite);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(223, 444);
            this.panelLeft.TabIndex = 1;
            // 
            // btnPainelMudarSenha
            // 
            this.btnPainelMudarSenha.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelMudarSenha.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelMudarSenha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPainelMudarSenha.BorderRadius = 10;
            this.btnPainelMudarSenha.BorderSize = 0;
            this.btnPainelMudarSenha.FlatAppearance.BorderSize = 0;
            this.btnPainelMudarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainelMudarSenha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPainelMudarSenha.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPainelMudarSenha.Location = new System.Drawing.Point(33, 269);
            this.btnPainelMudarSenha.Margin = new System.Windows.Forms.Padding(28, 40, 29, 3);
            this.btnPainelMudarSenha.Name = "btnPainelMudarSenha";
            this.btnPainelMudarSenha.Size = new System.Drawing.Size(158, 59);
            this.btnPainelMudarSenha.TabIndex = 2;
            this.btnPainelMudarSenha.Text = "Mudar Senha";
            this.btnPainelMudarSenha.TextColor = System.Drawing.Color.PeachPuff;
            this.btnPainelMudarSenha.UseVisualStyleBackColor = false;
            this.btnPainelMudarSenha.Click += new System.EventHandler(this.btnPainelMudarSenha_Click);
            // 
            // btnPainelProcurarSite
            // 
            this.btnPainelProcurarSite.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelProcurarSite.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelProcurarSite.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPainelProcurarSite.BorderRadius = 10;
            this.btnPainelProcurarSite.BorderSize = 0;
            this.btnPainelProcurarSite.FlatAppearance.BorderSize = 0;
            this.btnPainelProcurarSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainelProcurarSite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPainelProcurarSite.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPainelProcurarSite.Location = new System.Drawing.Point(33, 167);
            this.btnPainelProcurarSite.Margin = new System.Windows.Forms.Padding(28, 40, 29, 3);
            this.btnPainelProcurarSite.Name = "btnPainelProcurarSite";
            this.btnPainelProcurarSite.Size = new System.Drawing.Size(158, 59);
            this.btnPainelProcurarSite.TabIndex = 1;
            this.btnPainelProcurarSite.Text = "Procurar Site";
            this.btnPainelProcurarSite.TextColor = System.Drawing.Color.PeachPuff;
            this.btnPainelProcurarSite.UseVisualStyleBackColor = false;
            this.btnPainelProcurarSite.Click += new System.EventHandler(this.btnPainelProcurarSite_Click);
            // 
            // btnPainelCadastrarSite
            // 
            this.btnPainelCadastrarSite.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelCadastrarSite.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPainelCadastrarSite.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPainelCadastrarSite.BorderRadius = 10;
            this.btnPainelCadastrarSite.BorderSize = 0;
            this.btnPainelCadastrarSite.FlatAppearance.BorderSize = 0;
            this.btnPainelCadastrarSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainelCadastrarSite.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPainelCadastrarSite.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnPainelCadastrarSite.Location = new System.Drawing.Point(33, 65);
            this.btnPainelCadastrarSite.Margin = new System.Windows.Forms.Padding(28, 3, 29, 3);
            this.btnPainelCadastrarSite.Name = "btnPainelCadastrarSite";
            this.btnPainelCadastrarSite.Size = new System.Drawing.Size(158, 59);
            this.btnPainelCadastrarSite.TabIndex = 0;
            this.btnPainelCadastrarSite.Text = "Cadastrar";
            this.btnPainelCadastrarSite.TextColor = System.Drawing.Color.PeachPuff;
            this.btnPainelCadastrarSite.UseVisualStyleBackColor = false;
            this.btnPainelCadastrarSite.Click += new System.EventHandler(this.btnPainelCadastrarSite_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelCentral.Location = new System.Drawing.Point(223, 70);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(699, 444);
            this.panelCentral.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(922, 514);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel panelSuperior;
    private Panel panelLeft;
    private Panel panelCentral;
    private Label label1;
    private PedroControls.PedroButtom btnPainelCadastrarSite;
    private PedroControls.PedroButtom btnPainelMudarSenha;
    private PedroControls.PedroButtom btnPainelProcurarSite;
}
