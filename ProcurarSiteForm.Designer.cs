namespace SalvadorDeSenhas
{
    partial class ProcurarSiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurarSiteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_DoProcurarForm = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.listBox_DoProcurarForm = new System.Windows.Forms.ListBox();
            this.btnProcurar_DoFormProcurar = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(233, 0, 233, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurar Site";
            // 
            // txtNome_DoProcurarForm
            // 
            this.txtNome_DoProcurarForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.txtNome_DoProcurarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome_DoProcurarForm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome_DoProcurarForm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome_DoProcurarForm.BorderSize = 4;
            this.txtNome_DoProcurarForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNome_DoProcurarForm.ForeColor = System.Drawing.Color.Gray;
            this.txtNome_DoProcurarForm.Location = new System.Drawing.Point(134, 111);
            this.txtNome_DoProcurarForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome_DoProcurarForm.Multiline = false;
            this.txtNome_DoProcurarForm.Name = "txtNome_DoProcurarForm";
            this.txtNome_DoProcurarForm.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome_DoProcurarForm.PasswordChar = false;
            this.txtNome_DoProcurarForm.PlaceholderText = "Digite o nome do site";
            this.txtNome_DoProcurarForm.Size = new System.Drawing.Size(369, 37);
            this.txtNome_DoProcurarForm.TabIndex = 1;
            this.txtNome_DoProcurarForm.Texts = "";
            this.txtNome_DoProcurarForm.UnderlinedStyle = true;
            // 
            // listBox_DoProcurarForm
            // 
            this.listBox_DoProcurarForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBox_DoProcurarForm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox_DoProcurarForm.FormattingEnabled = true;
            this.listBox_DoProcurarForm.ItemHeight = 29;
            this.listBox_DoProcurarForm.Location = new System.Drawing.Point(134, 203);
            this.listBox_DoProcurarForm.Margin = new System.Windows.Forms.Padding(125, 3, 125, 3);
            this.listBox_DoProcurarForm.Name = "listBox_DoProcurarForm";
            this.listBox_DoProcurarForm.Size = new System.Drawing.Size(436, 178);
            this.listBox_DoProcurarForm.TabIndex = 2;
            // 
            // btnProcurar_DoFormProcurar
            // 
            this.btnProcurar_DoFormProcurar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProcurar_DoFormProcurar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProcurar_DoFormProcurar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProcurar_DoFormProcurar.BorderRadius = 35;
            this.btnProcurar_DoFormProcurar.BorderSize = 0;
            this.btnProcurar_DoFormProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar_DoFormProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar_DoFormProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar_DoFormProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar_DoFormProcurar.Image")));
            this.btnProcurar_DoFormProcurar.Location = new System.Drawing.Point(510, 113);
            this.btnProcurar_DoFormProcurar.Name = "btnProcurar_DoFormProcurar";
            this.btnProcurar_DoFormProcurar.Size = new System.Drawing.Size(60, 35);
            this.btnProcurar_DoFormProcurar.TabIndex = 3;
            this.btnProcurar_DoFormProcurar.TextColor = System.Drawing.Color.White;
            this.btnProcurar_DoFormProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar_DoFormProcurar.Click += new System.EventHandler(this.btnProcurar_DoFormProcurar_Click);
            // 
            // ProcurarSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(699, 444);
            this.Controls.Add(this.btnProcurar_DoFormProcurar);
            this.Controls.Add(this.listBox_DoProcurarForm);
            this.Controls.Add(this.txtNome_DoProcurarForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcurarSiteForm";
            this.Text = "ProcurarSiteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PedroControls.PedroTextBox txtNome_DoProcurarForm;
        private ListBox listBox_DoProcurarForm;
        private PedroControls.PedroButtom btnProcurar_DoFormProcurar;
    }
}