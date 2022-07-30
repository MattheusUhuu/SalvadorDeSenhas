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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTxt_DoProcurarSiteForm = new SalvadorDeSenhas.PedroControls.PedroTextBox();
            this.listBox_DoProcurarForm = new System.Windows.Forms.ListBox();
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
            // NomeTxt_DoProcurarSiteForm
            // 
            this.NomeTxt_DoProcurarSiteForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.NomeTxt_DoProcurarSiteForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NomeTxt_DoProcurarSiteForm.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.NomeTxt_DoProcurarSiteForm.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NomeTxt_DoProcurarSiteForm.BorderSize = 4;
            this.NomeTxt_DoProcurarSiteForm.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NomeTxt_DoProcurarSiteForm.ForeColor = System.Drawing.Color.Gray;
            this.NomeTxt_DoProcurarSiteForm.Location = new System.Drawing.Point(201, 111);
            this.NomeTxt_DoProcurarSiteForm.Margin = new System.Windows.Forms.Padding(4);
            this.NomeTxt_DoProcurarSiteForm.Multiline = false;
            this.NomeTxt_DoProcurarSiteForm.Name = "NomeTxt_DoProcurarSiteForm";
            this.NomeTxt_DoProcurarSiteForm.Padding = new System.Windows.Forms.Padding(7);
            this.NomeTxt_DoProcurarSiteForm.PasswordChar = false;
            this.NomeTxt_DoProcurarSiteForm.PlaceholderText = "Digite o nome do site";
            this.NomeTxt_DoProcurarSiteForm.Size = new System.Drawing.Size(312, 37);
            this.NomeTxt_DoProcurarSiteForm.TabIndex = 1;
            this.NomeTxt_DoProcurarSiteForm.Texts = "";
            this.NomeTxt_DoProcurarSiteForm.UnderlinedStyle = true;
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
            // ProcurarSiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(699, 444);
            this.Controls.Add(this.listBox_DoProcurarForm);
            this.Controls.Add(this.NomeTxt_DoProcurarSiteForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcurarSiteForm";
            this.Text = "ProcurarSiteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PedroControls.PedroTextBox NomeTxt_DoProcurarSiteForm;
        private ListBox listBox_DoProcurarForm;
    }
}