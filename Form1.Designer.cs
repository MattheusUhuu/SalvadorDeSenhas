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
            this.Cadastrar_btnInicio = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.Procurar_btnInicio = new SalvadorDeSenhas.PedroControls.PedroButtom();
            this.pedroButtom1 = new SalvadorDeSenhas.PedroControls.PedroButtom();
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
            this.panelLeft.Controls.Add(this.pedroButtom1);
            this.panelLeft.Controls.Add(this.Procurar_btnInicio);
            this.panelLeft.Controls.Add(this.Cadastrar_btnInicio);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(223, 444);
            this.panelLeft.TabIndex = 1;
            // 
            // Cadastrar_btnInicio
            // 
            this.Cadastrar_btnInicio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cadastrar_btnInicio.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Cadastrar_btnInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Cadastrar_btnInicio.BorderRadius = 10;
            this.Cadastrar_btnInicio.BorderSize = 0;
            this.Cadastrar_btnInicio.FlatAppearance.BorderSize = 0;
            this.Cadastrar_btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar_btnInicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cadastrar_btnInicio.ForeColor = System.Drawing.Color.PeachPuff;
            this.Cadastrar_btnInicio.Location = new System.Drawing.Point(33, 65);
            this.Cadastrar_btnInicio.Margin = new System.Windows.Forms.Padding(28, 3, 29, 3);
            this.Cadastrar_btnInicio.Name = "Cadastrar_btnInicio";
            this.Cadastrar_btnInicio.Size = new System.Drawing.Size(158, 59);
            this.Cadastrar_btnInicio.TabIndex = 0;
            this.Cadastrar_btnInicio.Text = "Cadastrar";
            this.Cadastrar_btnInicio.TextColor = System.Drawing.Color.PeachPuff;
            this.Cadastrar_btnInicio.UseVisualStyleBackColor = false;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(223, 70);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(699, 444);
            this.panelCentral.TabIndex = 2;
            // 
            // Procurar_btnInicio
            // 
            this.Procurar_btnInicio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Procurar_btnInicio.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Procurar_btnInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Procurar_btnInicio.BorderRadius = 10;
            this.Procurar_btnInicio.BorderSize = 0;
            this.Procurar_btnInicio.FlatAppearance.BorderSize = 0;
            this.Procurar_btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Procurar_btnInicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Procurar_btnInicio.ForeColor = System.Drawing.Color.PeachPuff;
            this.Procurar_btnInicio.Location = new System.Drawing.Point(33, 167);
            this.Procurar_btnInicio.Margin = new System.Windows.Forms.Padding(28, 40, 29, 3);
            this.Procurar_btnInicio.Name = "Procurar_btnInicio";
            this.Procurar_btnInicio.Size = new System.Drawing.Size(158, 59);
            this.Procurar_btnInicio.TabIndex = 1;
            this.Procurar_btnInicio.Text = "Procurar Site";
            this.Procurar_btnInicio.TextColor = System.Drawing.Color.PeachPuff;
            this.Procurar_btnInicio.UseVisualStyleBackColor = false;
            // 
            // pedroButtom1
            // 
            this.pedroButtom1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pedroButtom1.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.pedroButtom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pedroButtom1.BorderRadius = 10;
            this.pedroButtom1.BorderSize = 0;
            this.pedroButtom1.FlatAppearance.BorderSize = 0;
            this.pedroButtom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedroButtom1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pedroButtom1.ForeColor = System.Drawing.Color.PeachPuff;
            this.pedroButtom1.Location = new System.Drawing.Point(33, 269);
            this.pedroButtom1.Margin = new System.Windows.Forms.Padding(28, 40, 29, 3);
            this.pedroButtom1.Name = "pedroButtom1";
            this.pedroButtom1.Size = new System.Drawing.Size(158, 59);
            this.pedroButtom1.TabIndex = 2;
            this.pedroButtom1.Text = "Mudar Senha";
            this.pedroButtom1.TextColor = System.Drawing.Color.PeachPuff;
            this.pedroButtom1.UseVisualStyleBackColor = false;
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
    private PedroControls.PedroButtom Cadastrar_btnInicio;
    private PedroControls.PedroButtom pedroButtom1;
    private PedroControls.PedroButtom Procurar_btnInicio;
}
