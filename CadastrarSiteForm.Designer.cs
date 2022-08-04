namespace SalvadorDeSenhas
{
    partial class CadastrarSiteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrarSiteLabel = new System.Windows.Forms.Label();
            this.txtNomeDeCadastro = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.txtUrlCadastro = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.txtSenhaCadastro = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.checkBoxCaracteresEspeciais_FormCadastrar = new System.Windows.Forms.CheckBox();
            this.checkBoxMaiusculas_FormCadastrar = new System.Windows.Forms.CheckBox();
            this.checkBoxMinusculas_FormCadastrar = new System.Windows.Forms.CheckBox();
            this.btnCadastrar_DoFormCadastrar = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.btnGerarSenha_DoFormCadastrar = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.SuspendLayout();
            // 
            // cadastrarSiteLabel
            // 
            this.cadastrarSiteLabel.AutoSize = true;
            this.cadastrarSiteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadastrarSiteLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cadastrarSiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cadastrarSiteLabel.Location = new System.Drawing.Point(197, 9);
            this.cadastrarSiteLabel.Name = "cadastrarSiteLabel";
            this.cadastrarSiteLabel.Size = new System.Drawing.Size(308, 44);
            this.cadastrarSiteLabel.TabIndex = 0;
            this.cadastrarSiteLabel.Text = "Cadastrar novo site";
            this.cadastrarSiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeDeCadastro
            // 
            this.txtNomeDeCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtNomeDeCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomeDeCadastro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNomeDeCadastro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNomeDeCadastro.BorderSize = 4;
            this.txtNomeDeCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNomeDeCadastro.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeDeCadastro.Location = new System.Drawing.Point(197, 103);
            this.txtNomeDeCadastro.Margin = new System.Windows.Forms.Padding(186, 50, 185, 4);
            this.txtNomeDeCadastro.Multiline = false;
            this.txtNomeDeCadastro.Name = "txtNomeDeCadastro";
            this.txtNomeDeCadastro.Padding = new System.Windows.Forms.Padding(7);
            this.txtNomeDeCadastro.PasswordChar = false;
            this.txtNomeDeCadastro.PlaceholderText = "Informe o nome do site";
            this.txtNomeDeCadastro.Size = new System.Drawing.Size(312, 37);
            this.txtNomeDeCadastro.TabIndex = 1;
            this.txtNomeDeCadastro.Texts = "";
            this.txtNomeDeCadastro.UnderlinedStyle = true;
            // 
            // txtUrlCadastro
            // 
            this.txtUrlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtUrlCadastro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUrlCadastro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUrlCadastro.BorderSize = 4;
            this.txtUrlCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtUrlCadastro.ForeColor = System.Drawing.Color.Gray;
            this.txtUrlCadastro.Location = new System.Drawing.Point(197, 194);
            this.txtUrlCadastro.Margin = new System.Windows.Forms.Padding(4, 50, 4, 4);
            this.txtUrlCadastro.Multiline = false;
            this.txtUrlCadastro.Name = "txtUrlCadastro";
            this.txtUrlCadastro.Padding = new System.Windows.Forms.Padding(7);
            this.txtUrlCadastro.PasswordChar = false;
            this.txtUrlCadastro.PlaceholderText = "Informe o link do site";
            this.txtUrlCadastro.Size = new System.Drawing.Size(312, 37);
            this.txtUrlCadastro.TabIndex = 2;
            this.txtUrlCadastro.Texts = "";
            this.txtUrlCadastro.UnderlinedStyle = true;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtSenhaCadastro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenhaCadastro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSenhaCadastro.BorderSize = 4;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtSenhaCadastro.ForeColor = System.Drawing.Color.Gray;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(197, 285);
            this.txtSenhaCadastro.Margin = new System.Windows.Forms.Padding(4, 50, 4, 4);
            this.txtSenhaCadastro.Multiline = false;
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Padding = new System.Windows.Forms.Padding(7);
            this.txtSenhaCadastro.PasswordChar = false;
            this.txtSenhaCadastro.PlaceholderText = "Digite uma senha";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(312, 37);
            this.txtSenhaCadastro.TabIndex = 3;
            this.txtSenhaCadastro.Texts = "";
            this.txtSenhaCadastro.UnderlinedStyle = true;
            // 
            // checkBoxCaracteresEspeciais_FormCadastrar
            // 
            this.checkBoxCaracteresEspeciais_FormCadastrar.AutoSize = true;
            this.checkBoxCaracteresEspeciais_FormCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCaracteresEspeciais_FormCadastrar.ForeColor = System.Drawing.Color.Wheat;
            this.checkBoxCaracteresEspeciais_FormCadastrar.Location = new System.Drawing.Point(197, 329);
            this.checkBoxCaracteresEspeciais_FormCadastrar.Name = "checkBoxCaracteresEspeciais_FormCadastrar";
            this.checkBoxCaracteresEspeciais_FormCadastrar.Size = new System.Drawing.Size(71, 25);
            this.checkBoxCaracteresEspeciais_FormCadastrar.TabIndex = 4;
            this.checkBoxCaracteresEspeciais_FormCadastrar.Tag = "!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_";
            this.checkBoxCaracteresEspeciais_FormCadastrar.Text = "@#%";
            this.checkBoxCaracteresEspeciais_FormCadastrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaiusculas_FormCadastrar
            // 
            this.checkBoxMaiusculas_FormCadastrar.AutoSize = true;
            this.checkBoxMaiusculas_FormCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMaiusculas_FormCadastrar.ForeColor = System.Drawing.Color.Wheat;
            this.checkBoxMaiusculas_FormCadastrar.Location = new System.Drawing.Point(323, 329);
            this.checkBoxMaiusculas_FormCadastrar.Name = "checkBoxMaiusculas_FormCadastrar";
            this.checkBoxMaiusculas_FormCadastrar.Size = new System.Drawing.Size(61, 25);
            this.checkBoxMaiusculas_FormCadastrar.TabIndex = 5;
            this.checkBoxMaiusculas_FormCadastrar.Tag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.checkBoxMaiusculas_FormCadastrar.Text = "ABC";
            this.checkBoxMaiusculas_FormCadastrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinusculas_FormCadastrar
            // 
            this.checkBoxMinusculas_FormCadastrar.AutoSize = true;
            this.checkBoxMinusculas_FormCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMinusculas_FormCadastrar.ForeColor = System.Drawing.Color.Wheat;
            this.checkBoxMinusculas_FormCadastrar.Location = new System.Drawing.Point(454, 329);
            this.checkBoxMinusculas_FormCadastrar.Name = "checkBoxMinusculas_FormCadastrar";
            this.checkBoxMinusculas_FormCadastrar.Size = new System.Drawing.Size(57, 25);
            this.checkBoxMinusculas_FormCadastrar.TabIndex = 6;
            this.checkBoxMinusculas_FormCadastrar.Tag = "abcdefghijklmnopqrstuvwxyz";
            this.checkBoxMinusculas_FormCadastrar.Text = "abc";
            this.checkBoxMinusculas_FormCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar_DoFormCadastrar
            // 
            this.btnCadastrar_DoFormCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnCadastrar_DoFormCadastrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnCadastrar_DoFormCadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCadastrar_DoFormCadastrar.BorderRadius = 27;
            this.btnCadastrar_DoFormCadastrar.BorderSize = 0;
            this.btnCadastrar_DoFormCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar_DoFormCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_DoFormCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar_DoFormCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar_DoFormCadastrar.Location = new System.Drawing.Point(197, 382);
            this.btnCadastrar_DoFormCadastrar.Name = "btnCadastrar_DoFormCadastrar";
            this.btnCadastrar_DoFormCadastrar.Size = new System.Drawing.Size(118, 39);
            this.btnCadastrar_DoFormCadastrar.TabIndex = 7;
            this.btnCadastrar_DoFormCadastrar.Text = "Cadastrar";
            this.btnCadastrar_DoFormCadastrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCadastrar_DoFormCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar_DoFormCadastrar.Click += new System.EventHandler(this.btnCadastrar_DoFormCadastrar_Click);
            // 
            // btnGerarSenha_DoFormCadastrar
            // 
            this.btnGerarSenha_DoFormCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnGerarSenha_DoFormCadastrar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnGerarSenha_DoFormCadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGerarSenha_DoFormCadastrar.BorderRadius = 27;
            this.btnGerarSenha_DoFormCadastrar.BorderSize = 0;
            this.btnGerarSenha_DoFormCadastrar.FlatAppearance.BorderSize = 0;
            this.btnGerarSenha_DoFormCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSenha_DoFormCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGerarSenha_DoFormCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerarSenha_DoFormCadastrar.Location = new System.Drawing.Point(363, 382);
            this.btnGerarSenha_DoFormCadastrar.Name = "btnGerarSenha_DoFormCadastrar";
            this.btnGerarSenha_DoFormCadastrar.Size = new System.Drawing.Size(148, 39);
            this.btnGerarSenha_DoFormCadastrar.TabIndex = 8;
            this.btnGerarSenha_DoFormCadastrar.Text = "Gerar Senha";
            this.btnGerarSenha_DoFormCadastrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerarSenha_DoFormCadastrar.UseVisualStyleBackColor = false;
            this.btnGerarSenha_DoFormCadastrar.Click += new System.EventHandler(this.btnGerarSenha_DoFormCadastrar_Click);
            // 
            // CadastrarSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(699, 444);
            this.Controls.Add(this.btnGerarSenha_DoFormCadastrar);
            this.Controls.Add(this.btnCadastrar_DoFormCadastrar);
            this.Controls.Add(this.checkBoxMinusculas_FormCadastrar);
            this.Controls.Add(this.checkBoxMaiusculas_FormCadastrar);
            this.Controls.Add(this.checkBoxCaracteresEspeciais_FormCadastrar);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtUrlCadastro);
            this.Controls.Add(this.txtNomeDeCadastro);
            this.Controls.Add(this.cadastrarSiteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarSiteForm";
            this.Text = "CadastrarSiteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cadastrarSiteLabel;
        private PedroControls.PedroTextBox txtUrlCadastro;
        private PedroControls.PedroTextBox txtSenhaCadastro;
        private CheckBox checkBoxCaracteresEspeciais_FormCadastrar;
        private CheckBox checkBoxMaiusculas_FormCadastrar;
        private CheckBox checkBoxMinusculas_FormCadastrar;
        private PedroControls.PedroButtom btnCadastrar_DoFormCadastrar;
        private PedroControls.PedroButtom btnGerarSenha_DoFormCadastrar;
        private PedroControls.PedroTextBox txtNomeDeCadastro;
    }
}