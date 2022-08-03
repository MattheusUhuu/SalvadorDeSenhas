namespace SalvadorDeSenhas
{
    partial class MudarSenhaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_DoAlterarSenhaForm = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.txtNovaSenha_DoAlterarSenhaForm = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.checkBoxMostrarSenhas_DoFormMudarSenha = new System.Windows.Forms.CheckBox();
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm = new System.Windows.Forms.CheckBox();
            this.checkBoxMaiusculas_DoAlterarSenhaForm = new System.Windows.Forms.CheckBox();
            this.checkBoxMinusculas_DoAlterarSenhaForm = new System.Windows.Forms.CheckBox();
            this.btnAlterarSenha = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.btnGerarSenha_DoAlterarSenhaForm = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(225, 0, 225, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Senha";
            // 
            // txtNome_DoAlterarSenhaForm
            // 
            this.txtNome_DoAlterarSenhaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtNome_DoAlterarSenhaForm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome_DoAlterarSenhaForm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome_DoAlterarSenhaForm.BorderSize = 4;
            this.txtNome_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNome_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.Gray;
            this.txtNome_DoAlterarSenhaForm.Location = new System.Drawing.Point(195, 101);
            this.txtNome_DoAlterarSenhaForm.Margin = new System.Windows.Forms.Padding(186, 50, 185, 4);
            this.txtNome_DoAlterarSenhaForm.Multiline = false;
            this.txtNome_DoAlterarSenhaForm.Name = "txtNome_DoAlterarSenhaForm";
            this.txtNome_DoAlterarSenhaForm.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome_DoAlterarSenhaForm.PasswordChar = false;
            this.txtNome_DoAlterarSenhaForm.PlaceholderText = "Digite o nome do site";
            this.txtNome_DoAlterarSenhaForm.Size = new System.Drawing.Size(312, 37);
            this.txtNome_DoAlterarSenhaForm.TabIndex = 1;
            this.txtNome_DoAlterarSenhaForm.Texts = "";
            this.txtNome_DoAlterarSenhaForm.UnderlinedStyle = true;
            // 
            // txtNovaSenha_DoAlterarSenhaForm
            // 
            this.txtNovaSenha_DoAlterarSenhaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtNovaSenha_DoAlterarSenhaForm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNovaSenha_DoAlterarSenhaForm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNovaSenha_DoAlterarSenhaForm.BorderSize = 4;
            this.txtNovaSenha_DoAlterarSenhaForm.Enabled = false;
            this.txtNovaSenha_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNovaSenha_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.Gray;
            this.txtNovaSenha_DoAlterarSenhaForm.Location = new System.Drawing.Point(195, 192);
            this.txtNovaSenha_DoAlterarSenhaForm.Margin = new System.Windows.Forms.Padding(186, 50, 185, 4);
            this.txtNovaSenha_DoAlterarSenhaForm.Multiline = false;
            this.txtNovaSenha_DoAlterarSenhaForm.Name = "txtNovaSenha_DoAlterarSenhaForm";
            this.txtNovaSenha_DoAlterarSenhaForm.Padding = new System.Windows.Forms.Padding(7);
            this.txtNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
            this.txtNovaSenha_DoAlterarSenhaForm.PlaceholderText = "Informe uma nova senha";
            this.txtNovaSenha_DoAlterarSenhaForm.Size = new System.Drawing.Size(312, 37);
            this.txtNovaSenha_DoAlterarSenhaForm.TabIndex = 2;
            this.txtNovaSenha_DoAlterarSenhaForm.Texts = "";
            this.txtNovaSenha_DoAlterarSenhaForm.UnderlinedStyle = true;
            // 
            // txtConfirmarNovaSenha_DoAlterarSenhaForm
            // 
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.BorderSize = 4;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Enabled = false;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Location = new System.Drawing.Point(195, 283);
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Margin = new System.Windows.Forms.Padding(186, 50, 185, 4);
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Multiline = false;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Name = "txtConfirmarNovaSenha_DoAlterarSenhaForm";
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.PasswordChar = false;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.PlaceholderText = "Confirme a nova senha";
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Size = new System.Drawing.Size(312, 37);
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.TabIndex = 3;
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.Texts = "";
            this.txtConfirmarNovaSenha_DoAlterarSenhaForm.UnderlinedStyle = true;
            // 
            // checkBoxMostrarSenhas_DoFormMudarSenha
            // 
            this.checkBoxMostrarSenhas_DoFormMudarSenha.AutoSize = true;
            this.checkBoxMostrarSenhas_DoFormMudarSenha.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxMostrarSenhas_DoFormMudarSenha.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxMostrarSenhas_DoFormMudarSenha.Location = new System.Drawing.Point(195, 327);
            this.checkBoxMostrarSenhas_DoFormMudarSenha.Name = "checkBoxMostrarSenhas_DoFormMudarSenha";
            this.checkBoxMostrarSenhas_DoFormMudarSenha.Size = new System.Drawing.Size(186, 28);
            this.checkBoxMostrarSenhas_DoFormMudarSenha.TabIndex = 4;
            this.checkBoxMostrarSenhas_DoFormMudarSenha.Text = "Mostrar as Senhas";
            this.checkBoxMostrarSenhas_DoFormMudarSenha.UseVisualStyleBackColor = true;
            this.checkBoxMostrarSenhas_DoFormMudarSenha.CheckedChanged += new System.EventHandler(this.checkBoxMostrarSenhas_DoFormMudarSenha_CheckedChanged);
            // 
            // checkBoxCaracteresEspeciais_doAlterarSenhaForm
            // 
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.AutoSize = true;
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Location = new System.Drawing.Point(195, 361);
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Name = "checkBoxCaracteresEspeciais_doAlterarSenhaForm";
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Size = new System.Drawing.Size(65, 23);
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.TabIndex = 5;
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Tag = "!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_!@#$%&_";
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.Text = "@#%";
            this.checkBoxCaracteresEspeciais_doAlterarSenhaForm.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaiusculas_DoAlterarSenhaForm
            // 
            this.checkBoxMaiusculas_DoAlterarSenhaForm.AutoSize = true;
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxMaiusculas_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Location = new System.Drawing.Point(324, 361);
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Name = "checkBoxMaiusculas_DoAlterarSenhaForm";
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Size = new System.Drawing.Size(57, 23);
            this.checkBoxMaiusculas_DoAlterarSenhaForm.TabIndex = 6;
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Tag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.checkBoxMaiusculas_DoAlterarSenhaForm.Text = "ABC";
            this.checkBoxMaiusculas_DoAlterarSenhaForm.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinusculas_DoAlterarSenhaForm
            // 
            this.checkBoxMinusculas_DoAlterarSenhaForm.AutoSize = true;
            this.checkBoxMinusculas_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxMinusculas_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxMinusculas_DoAlterarSenhaForm.Location = new System.Drawing.Point(450, 361);
            this.checkBoxMinusculas_DoAlterarSenhaForm.Name = "checkBoxMinusculas_DoAlterarSenhaForm";
            this.checkBoxMinusculas_DoAlterarSenhaForm.Size = new System.Drawing.Size(53, 23);
            this.checkBoxMinusculas_DoAlterarSenhaForm.TabIndex = 7;
            this.checkBoxMinusculas_DoAlterarSenhaForm.Tag = "abcdefghijklmnopqrstuvwxyz";
            this.checkBoxMinusculas_DoAlterarSenhaForm.Text = "abc";
            this.checkBoxMinusculas_DoAlterarSenhaForm.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnAlterarSenha.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnAlterarSenha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAlterarSenha.BorderRadius = 29;
            this.btnAlterarSenha.BorderSize = 0;
            this.btnAlterarSenha.Enabled = false;
            this.btnAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarSenha.Location = new System.Drawing.Point(83, 291);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(108, 29);
            this.btnAlterarSenha.TabIndex = 8;
            this.btnAlterarSenha.Text = "Alterar";
            this.btnAlterarSenha.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnGerarSenha_DoAlterarSenhaForm
            // 
            this.btnGerarSenha_DoAlterarSenhaForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnGerarSenha_DoAlterarSenhaForm.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnGerarSenha_DoAlterarSenhaForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGerarSenha_DoAlterarSenhaForm.BorderRadius = 29;
            this.btnGerarSenha_DoAlterarSenhaForm.BorderSize = 0;
            this.btnGerarSenha_DoAlterarSenhaForm.FlatAppearance.BorderSize = 0;
            this.btnGerarSenha_DoAlterarSenhaForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSenha_DoAlterarSenhaForm.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGerarSenha_DoAlterarSenhaForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerarSenha_DoAlterarSenhaForm.Location = new System.Drawing.Point(511, 291);
            this.btnGerarSenha_DoAlterarSenhaForm.Name = "btnGerarSenha_DoAlterarSenhaForm";
            this.btnGerarSenha_DoAlterarSenhaForm.Size = new System.Drawing.Size(142, 29);
            this.btnGerarSenha_DoAlterarSenhaForm.TabIndex = 9;
            this.btnGerarSenha_DoAlterarSenhaForm.Text = "Gerar Senha";
            this.btnGerarSenha_DoAlterarSenhaForm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGerarSenha_DoAlterarSenhaForm.UseVisualStyleBackColor = false;
            this.btnGerarSenha_DoAlterarSenhaForm.Click += new System.EventHandler(this.btnGerarSenha_DoAlterarSenhaForm_Click);
            // 
            // MudarSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(699, 444);
            this.Controls.Add(this.btnGerarSenha_DoAlterarSenhaForm);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.checkBoxMinusculas_DoAlterarSenhaForm);
            this.Controls.Add(this.checkBoxMaiusculas_DoAlterarSenhaForm);
            this.Controls.Add(this.checkBoxCaracteresEspeciais_doAlterarSenhaForm);
            this.Controls.Add(this.checkBoxMostrarSenhas_DoFormMudarSenha);
            this.Controls.Add(this.txtConfirmarNovaSenha_DoAlterarSenhaForm);
            this.Controls.Add(this.txtNovaSenha_DoAlterarSenhaForm);
            this.Controls.Add(this.txtNome_DoAlterarSenhaForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MudarSenhaForm";
            this.Text = "MudarSenhaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PedroControls.PedroTextBox txtNome_DoAlterarSenhaForm;
        private PedroControls.PedroTextBox txtNovaSenha_DoAlterarSenhaForm;
        private PedroControls.PedroTextBox txtConfirmarNovaSenha_DoAlterarSenhaForm;
        private CheckBox checkBoxMostrarSenhas_DoFormMudarSenha;
        private CheckBox checkBoxCaracteresEspeciais_doAlterarSenhaForm;
        private CheckBox checkBoxMaiusculas_DoAlterarSenhaForm;
        private CheckBox checkBoxMinusculas_DoAlterarSenhaForm;
        private PedroControls.PedroButtom btnAlterarSenha;
        private PedroControls.PedroButtom btnGerarSenha_DoAlterarSenhaForm;
    }
}