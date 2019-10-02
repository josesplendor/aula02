namespace Aula02
{
    partial class FormIMC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.DiaNascimento = new System.Windows.Forms.ComboBox();
            this.AnoNascimento = new System.Windows.Forms.ComboBox();
            this.MesNascimento = new System.Windows.Forms.ComboBox();
            this.PesoKG = new System.Windows.Forms.Label();
            this.AlturaCM = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(527, 20);
            this.txtNome.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(79, 37);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(41, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome :";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Location = new System.Drawing.Point(51, 70);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(69, 13);
            this.Nascimento.TabIndex = 2;
            this.Nascimento.Text = "Nascimento :";
            // 
            // DiaNascimento
            // 
            this.DiaNascimento.FormattingEnabled = true;
            this.DiaNascimento.Location = new System.Drawing.Point(131, 67);
            this.DiaNascimento.Name = "DiaNascimento";
            this.DiaNascimento.Size = new System.Drawing.Size(49, 21);
            this.DiaNascimento.TabIndex = 3;
            // 
            // AnoNascimento
            // 
            this.AnoNascimento.FormattingEnabled = true;
            this.AnoNascimento.Location = new System.Drawing.Point(270, 67);
            this.AnoNascimento.Name = "AnoNascimento";
            this.AnoNascimento.Size = new System.Drawing.Size(79, 21);
            this.AnoNascimento.TabIndex = 4;
            // 
            // MesNascimento
            // 
            this.MesNascimento.FormattingEnabled = true;
            this.MesNascimento.Location = new System.Drawing.Point(186, 67);
            this.MesNascimento.Name = "MesNascimento";
            this.MesNascimento.Size = new System.Drawing.Size(78, 21);
            this.MesNascimento.TabIndex = 5;
            // 
            // PesoKG
            // 
            this.PesoKG.AutoSize = true;
            this.PesoKG.Location = new System.Drawing.Point(79, 105);
            this.PesoKG.Name = "PesoKG";
            this.PesoKG.Size = new System.Drawing.Size(37, 13);
            this.PesoKG.TabIndex = 6;
            this.PesoKG.Text = "Peso :";
            // 
            // AlturaCM
            // 
            this.AlturaCM.AutoSize = true;
            this.AlturaCM.Location = new System.Drawing.Point(79, 141);
            this.AlturaCM.Name = "AlturaCM";
            this.AlturaCM.Size = new System.Drawing.Size(40, 13);
            this.AlturaCM.TabIndex = 8;
            this.AlturaCM.Text = "Altura :";
            // 
            // IMC
            // 
            this.IMC.Location = new System.Drawing.Point(131, 177);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(104, 34);
            this.IMC.TabIndex = 10;
            this.IMC.Text = "Calculo IMC";
            this.IMC.UseVisualStyleBackColor = true;
            this.IMC.Click += new System.EventHandler(this.IMC_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(131, 102);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 11;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(131, 138);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 12;
            // 
            // FormIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.AlturaCM);
            this.Controls.Add(this.PesoKG);
            this.Controls.Add(this.MesNascimento);
            this.Controls.Add(this.AnoNascimento);
            this.Controls.Add(this.DiaNascimento);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNome);
            this.Name = "FormIMC";
            this.Text = "Calcule aqui seu IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.ComboBox DiaNascimento;
        private System.Windows.Forms.ComboBox AnoNascimento;
        private System.Windows.Forms.ComboBox MesNascimento;
        private System.Windows.Forms.Label PesoKG;
        private System.Windows.Forms.Label AlturaCM;
        private System.Windows.Forms.Button IMC;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

