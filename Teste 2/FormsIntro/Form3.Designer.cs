namespace Teste2
{
    partial class Form3
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
            this.lblProtocolo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.boxProtocolo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dateAbertura = new System.Windows.Forms.DateTimePicker();
            this.txtTituloChamado = new System.Windows.Forms.TextBox();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.lblTítuloChamado = new System.Windows.Forms.Label();
            this.boxEquipamento = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProtocolo
            // 
            this.lblProtocolo.AutoSize = true;
            this.lblProtocolo.Location = new System.Drawing.Point(12, 35);
            this.lblProtocolo.Name = "lblProtocolo";
            this.lblProtocolo.Size = new System.Drawing.Size(40, 13);
            this.lblProtocolo.TabIndex = 0;
            this.lblProtocolo.Text = "Codigo";
            this.lblProtocolo.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boxProtocolo
            // 
            this.boxProtocolo.FormattingEnabled = true;
            this.boxProtocolo.Location = new System.Drawing.Point(58, 32);
            this.boxProtocolo.Name = "boxProtocolo";
            this.boxProtocolo.Size = new System.Drawing.Size(133, 21);
            this.boxProtocolo.TabIndex = 7;
            this.boxProtocolo.Visible = false;
            this.boxProtocolo.SelectedIndexChanged += new System.EventHandler(this.boxCodigo_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(15, 131);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(657, 325);
            this.txtDescricao.TabIndex = 17;
            // 
            // dateAbertura
            // 
            this.dateAbertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateAbertura.Location = new System.Drawing.Point(105, 86);
            this.dateAbertura.Name = "dateAbertura";
            this.dateAbertura.Size = new System.Drawing.Size(227, 20);
            this.dateAbertura.TabIndex = 16;
            // 
            // txtTituloChamado
            // 
            this.txtTituloChamado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloChamado.Location = new System.Drawing.Point(116, 59);
            this.txtTituloChamado.Name = "txtTituloChamado";
            this.txtTituloChamado.Size = new System.Drawing.Size(556, 20);
            this.txtTituloChamado.TabIndex = 15;
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Location = new System.Drawing.Point(405, 88);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(69, 13);
            this.lblEquipamento.TabIndex = 13;
            this.lblEquipamento.Text = "Equipamento";
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Location = new System.Drawing.Point(12, 88);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(87, 13);
            this.lblDataAbertura.TabIndex = 12;
            this.lblDataAbertura.Text = "Data de abertura";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Location = new System.Drawing.Point(12, 115);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(58, 13);
            this.lblDescrição.TabIndex = 11;
            this.lblDescrição.Text = "Descrição:";
            // 
            // lblTítuloChamado
            // 
            this.lblTítuloChamado.AutoSize = true;
            this.lblTítuloChamado.Location = new System.Drawing.Point(12, 62);
            this.lblTítuloChamado.Name = "lblTítuloChamado";
            this.lblTítuloChamado.Size = new System.Drawing.Size(98, 13);
            this.lblTítuloChamado.TabIndex = 10;
            this.lblTítuloChamado.Text = "Título do Chamado";
            // 
            // boxEquipamento
            // 
            this.boxEquipamento.FormattingEnabled = true;
            this.boxEquipamento.Location = new System.Drawing.Point(480, 85);
            this.boxEquipamento.Name = "boxEquipamento";
            this.boxEquipamento.Size = new System.Drawing.Size(192, 21);
            this.boxEquipamento.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(210, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(516, 30);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(597, 30);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(291, 30);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dateAbertura);
            this.Controls.Add(this.txtTituloChamado);
            this.Controls.Add(this.boxEquipamento);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.lblDataAbertura);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.lblTítuloChamado);
            this.Controls.Add(this.boxProtocolo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblProtocolo);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro, edição e busca de chamados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProtocolo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox boxProtocolo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dateAbertura;
        private System.Windows.Forms.TextBox txtTituloChamado;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.Label lblTítuloChamado;
        private System.Windows.Forms.ComboBox boxEquipamento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}