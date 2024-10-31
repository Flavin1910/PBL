namespace Teste_PBL___Leide
{
    partial class Form1
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
            this.LargR = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LargRio = new System.Windows.Forms.TextBox();
            this.Varr = new System.Windows.Forms.TextBox();
            this.AngBarco = new System.Windows.Forms.TextBox();
            this.Vrel = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ArquivoPath = new System.Windows.Forms.TextBox();
            this.PathArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LargR
            // 
            this.LargR.AutoSize = true;
            this.LargR.Location = new System.Drawing.Point(46, 18);
            this.LargR.Name = "LargR";
            this.LargR.Size = new System.Drawing.Size(80, 13);
            this.LargR.TabIndex = 0;
            this.LargR.Text = "Largura do Rio:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(24, 113);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Velocidade de Arrasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ângulo teta do barco em relação a origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Velocidade Relativa do barco:";
            // 
            // LargRio
            // 
            this.LargRio.Location = new System.Drawing.Point(256, 15);
            this.LargRio.Name = "LargRio";
            this.LargRio.Size = new System.Drawing.Size(100, 20);
            this.LargRio.TabIndex = 4;
            // 
            // Varr
            // 
            this.Varr.Location = new System.Drawing.Point(256, 106);
            this.Varr.Name = "Varr";
            this.Varr.Size = new System.Drawing.Size(100, 20);
            this.Varr.TabIndex = 5;
            // 
            // AngBarco
            // 
            this.AngBarco.Location = new System.Drawing.Point(256, 162);
            this.AngBarco.Name = "AngBarco";
            this.AngBarco.Size = new System.Drawing.Size(100, 20);
            this.AngBarco.TabIndex = 6;
            // 
            // Vrel
            // 
            this.Vrel.Location = new System.Drawing.Point(256, 58);
            this.Vrel.Name = "Vrel";
            this.Vrel.Size = new System.Drawing.Size(100, 20);
            this.Vrel.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(118, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 39);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "criarArquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArquivoPath
            // 
            this.ArquivoPath.Location = new System.Drawing.Point(499, 51);
            this.ArquivoPath.Name = "ArquivoPath";
            this.ArquivoPath.Size = new System.Drawing.Size(100, 20);
            this.ArquivoPath.TabIndex = 10;
            // 
            // PathArquivo
            // 
            this.PathArquivo.Location = new System.Drawing.Point(233, 328);
            this.PathArquivo.Name = "PathArquivo";
            this.PathArquivo.Size = new System.Drawing.Size(123, 20);
            this.PathArquivo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Arquivo para adicionar os dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathArquivo);
            this.Controls.Add(this.ArquivoPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.Vrel);
            this.Controls.Add(this.AngBarco);
            this.Controls.Add(this.Varr);
            this.Controls.Add(this.LargRio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.LargR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LargR;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LargRio;
        private System.Windows.Forms.TextBox Varr;
        private System.Windows.Forms.TextBox AngBarco;
        private System.Windows.Forms.TextBox Vrel;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ArquivoPath;
        private System.Windows.Forms.TextBox PathArquivo;
        private System.Windows.Forms.Label label1;
    }
}

