namespace Teste2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.dateFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.boxEdicaoEquipamento = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEdicao = new System.Windows.Forms.Button();
            this.txtEdicaoFabricante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateEdicaoDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdicaoSerie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEdicaoPrecoAquisicao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdicaoEquipamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boxBuscaEquipamento = new System.Windows.Forms.ComboBox();
            this.txtBuscaFabricante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateBuscaDataFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscaSerie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuscaPrecoAquisicao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirChamadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtEquipamento
            // 
            resources.ApplyResources(this.txtEquipamento, "txtEquipamento");
            this.txtEquipamento.Name = "txtEquipamento";
            // 
            // txtPreco
            // 
            resources.ApplyResources(this.txtPreco, "txtPreco");
            this.txtPreco.Name = "txtPreco";
            // 
            // txtSerie
            // 
            resources.ApplyResources(this.txtSerie, "txtSerie");
            this.txtSerie.Name = "txtSerie";
            // 
            // dateFabricacao
            // 
            this.dateFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateFabricacao, "dateFabricacao");
            this.dateFabricacao.Name = "dateFabricacao";
            // 
            // txtFabricante
            // 
            resources.ApplyResources(this.txtFabricante, "txtFabricante");
            this.txtFabricante.Name = "txtFabricante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateFabricacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEquipamento);
            this.groupBox1.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Cadastrar);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.boxEdicaoEquipamento);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnEdicao);
            this.groupBox2.Controls.Add(this.txtEdicaoFabricante);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateEdicaoDataFabricacao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEdicaoSerie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEdicaoPrecoAquisicao);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtEdicaoEquipamento);
            this.groupBox2.Controls.Add(this.label10);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // boxEdicaoEquipamento
            // 
            this.boxEdicaoEquipamento.FormattingEnabled = true;
            resources.ApplyResources(this.boxEdicaoEquipamento, "boxEdicaoEquipamento");
            this.boxEdicaoEquipamento.Name = "boxEdicaoEquipamento";
            this.boxEdicaoEquipamento.SelectedIndexChanged += new System.EventHandler(this.boxEdicaoEquipamento_SelectedIndexChanged);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // btnEdicao
            // 
            resources.ApplyResources(this.btnEdicao, "btnEdicao");
            this.btnEdicao.Name = "btnEdicao";
            this.btnEdicao.UseVisualStyleBackColor = true;
            this.btnEdicao.Click += new System.EventHandler(this.btnEdicao_Click);
            // 
            // txtEdicaoFabricante
            // 
            resources.ApplyResources(this.txtEdicaoFabricante, "txtEdicaoFabricante");
            this.txtEdicaoFabricante.Name = "txtEdicaoFabricante";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dateEdicaoDataFabricacao
            // 
            this.dateEdicaoDataFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateEdicaoDataFabricacao, "dateEdicaoDataFabricacao");
            this.dateEdicaoDataFabricacao.Name = "dateEdicaoDataFabricacao";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtEdicaoSerie
            // 
            resources.ApplyResources(this.txtEdicaoSerie, "txtEdicaoSerie");
            this.txtEdicaoSerie.Name = "txtEdicaoSerie";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtEdicaoPrecoAquisicao
            // 
            resources.ApplyResources(this.txtEdicaoPrecoAquisicao, "txtEdicaoPrecoAquisicao");
            this.txtEdicaoPrecoAquisicao.Name = "txtEdicaoPrecoAquisicao";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtEdicaoEquipamento
            // 
            resources.ApplyResources(this.txtEdicaoEquipamento, "txtEdicaoEquipamento");
            this.txtEdicaoEquipamento.Name = "txtEdicaoEquipamento";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boxBuscaEquipamento);
            this.groupBox3.Controls.Add(this.txtBuscaFabricante);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dateBuscaDataFabricacao);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBuscaSerie);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBuscaPrecoAquisicao);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // boxBuscaEquipamento
            // 
            this.boxBuscaEquipamento.FormattingEnabled = true;
            resources.ApplyResources(this.boxBuscaEquipamento, "boxBuscaEquipamento");
            this.boxBuscaEquipamento.Name = "boxBuscaEquipamento";
            this.boxBuscaEquipamento.SelectedIndexChanged += new System.EventHandler(this.boxBuscaEquipamento_SelectedIndexChanged);
            // 
            // txtBuscaFabricante
            // 
            resources.ApplyResources(this.txtBuscaFabricante, "txtBuscaFabricante");
            this.txtBuscaFabricante.Name = "txtBuscaFabricante";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // dateBuscaDataFabricacao
            // 
            resources.ApplyResources(this.dateBuscaDataFabricacao, "dateBuscaDataFabricacao");
            this.dateBuscaDataFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBuscaDataFabricacao.Name = "dateBuscaDataFabricacao";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtBuscaSerie
            // 
            resources.ApplyResources(this.txtBuscaSerie, "txtBuscaSerie");
            this.txtBuscaSerie.Name = "txtBuscaSerie";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtBuscaPrecoAquisicao
            // 
            resources.ApplyResources(this.txtBuscaPrecoAquisicao, "txtBuscaPrecoAquisicao");
            this.txtBuscaPrecoAquisicao.Name = "txtBuscaPrecoAquisicao";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem1});
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            resources.ApplyResources(this.abrirChamadoToolStripMenuItem, "abrirChamadoToolStripMenuItem");
            // 
            // abrirChamadoToolStripMenuItem1
            // 
            this.abrirChamadoToolStripMenuItem1.Name = "abrirChamadoToolStripMenuItem1";
            resources.ApplyResources(this.abrirChamadoToolStripMenuItem1, "abrirChamadoToolStripMenuItem1");
            this.abrirChamadoToolStripMenuItem1.Click += new System.EventHandler(this.abrirChamadoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.DateTimePicker dateFabricacao;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdicao;
        private System.Windows.Forms.TextBox txtEdicaoFabricante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateEdicaoDataFabricacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdicaoSerie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEdicaoPrecoAquisicao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdicaoEquipamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBuscaFabricante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscaSerie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBuscaPrecoAquisicao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateBuscaDataFabricacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox boxBuscaEquipamento;
        private System.Windows.Forms.ComboBox boxEdicaoEquipamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem1;
    }
}

