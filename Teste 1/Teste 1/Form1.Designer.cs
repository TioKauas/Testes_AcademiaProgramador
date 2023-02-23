namespace Teste_1
{
    partial class Teste1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireita = new System.Windows.Forms.TextBox();
            this.txtEsquerda = new System.Windows.Forms.TextBox();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linha Inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Linha Direita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Linha Esquerda";
            // 
            // txtDireita
            // 
            this.txtDireita.Location = new System.Drawing.Point(84, 68);
            this.txtDireita.Name = "txtDireita";
            this.txtDireita.Size = new System.Drawing.Size(100, 20);
            this.txtDireita.TabIndex = 2;
            // 
            // txtEsquerda
            // 
            this.txtEsquerda.Location = new System.Drawing.Point(99, 92);
            this.txtEsquerda.Name = "txtEsquerda";
            this.txtEsquerda.Size = new System.Drawing.Size(100, 20);
            this.txtEsquerda.TabIndex = 3;
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(86, 116);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(100, 20);
            this.txtInferior.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Informe as medidas e descubra qual é o tipo de triangulo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Location = new System.Drawing.Point(39, 158);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(129, 30);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(248, 48);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(135, 131);
            this.picImage.TabIndex = 7;
            this.picImage.TabStop = false;
            this.picImage.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(57, 194);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(92, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(312, 194);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescricao.Size = new System.Drawing.Size(0, 16);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Teste1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 236);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.txtEsquerda);
            this.Controls.Add(this.txtDireita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(442, 275);
            this.MinimumSize = new System.Drawing.Size(442, 275);
            this.Name = "Teste1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste 1";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireita;
        private System.Windows.Forms.TextBox txtEsquerda;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDescricao;
    }
}

