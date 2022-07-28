namespace SalvadorDeSenhas.PedroControls
{
    partial class PedroTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PedroTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PedroTextBox1
            // 
            this.PedroTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PedroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PedroTextBox1.Location = new System.Drawing.Point(7, 7);
            this.PedroTextBox1.Name = "PedroTextBox1";
            this.PedroTextBox1.Size = new System.Drawing.Size(236, 20);
            this.PedroTextBox1.TabIndex = 0;
            this.PedroTextBox1.Enter += new System.EventHandler(this.PedroTextBox1_Enter_1);
            this.PedroTextBox1.Leave += new System.EventHandler(this.PedroTextBox1_Leave);
            // 
            // PedroTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PedroTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PedroTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PedroTextBox1;
    }
}
