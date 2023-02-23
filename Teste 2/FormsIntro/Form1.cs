using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Teste2
{
    public partial class Form1 : Form
    {
        Thread T1;
        private bool _ExcluirClick = false;

        List<Produto> Produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();            
        }

        #region Chamados
        private void abrirChamadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            T1 = new Thread(_abrirJanela);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }

        private void _abrirJanela(object obj)
        {
            Application.Run(new Form3());
        }
        #endregion

        #region Cadastro de Produto
        private void Cadastrar(object sender, EventArgs e)
        {
            int Index = -1;

            foreach (Produto p in Produtos)
            {
                if (p.nomeProduto == txtEquipamento.Text)
                {
                    Index = Produtos.IndexOf(p);
                }
            }

            #region Verificação dos campos
            if (txtEquipamento.Text == "" || txtPreco.Text == "" || txtSerie.Text == "" || txtFabricante.Text == "")
            {               
                MessageBox.Show("Preencha todos os campo.");
                txtEquipamento.Focus();
                return;
            }

            if (dateFabricacao.Value > DateTime.Now)
            {
                MessageBox.Show("Data Inválida");
                txtEquipamento.Focus();
                return;
            }
            #endregion

            Produto produto = new Produto();
            produto.nomeProduto = txtEquipamento.Text;
            produto.precoAquisicao = txtPreco.Text;
            produto.dataFabricacao = dateFabricacao.Text;
            produto.numeroSerie = txtSerie.Text; ;
            produto.Fabricante = txtFabricante.Text;

            if (Index < 0)
            {
                Produtos.Add(produto);
            }
            else 
            {
                Produtos[Index] = produto;
            }

            AtualizarBD();
            MessageBox.Show("Cadastro efetuado com sucesso!");
            btnLimpar_Click(btnLimpar, EventArgs.Empty);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEquipamento.Text = "";
            txtFabricante.Text = "";
            txtPreco.Text = "";
            txtSerie.Text = "";
        }
        #endregion

        #region Edição de item
        private void boxEdicaoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = boxEdicaoEquipamento.SelectedIndex;

            if (indice >= 0 && indice < Produtos.Count)
            {
                Produto p = Produtos[indice];

                txtEdicaoEquipamento.Text = p.nomeProduto;
                txtEdicaoPrecoAquisicao.Text = p.precoAquisicao;
                dateEdicaoDataFabricacao.Text = p.dataFabricacao;
                txtEdicaoSerie.Text = p.numeroSerie;
                txtEdicaoFabricante.Text = p.Fabricante;

                btnEdicao.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEdicao_Click(object sender, EventArgs e)
        {
            int indice = boxEdicaoEquipamento.SelectedIndex;
            if (indice >= 0 && indice < Produtos.Count)
            { 
                    Produto p = Produtos[indice];

                p.nomeProduto = txtEdicaoEquipamento.Text;
                p.precoAquisicao = txtEdicaoPrecoAquisicao.Text;
                p.dataFabricacao = dateFabricacao.Text;
                p.numeroSerie = txtEdicaoSerie.Text;
                p.Fabricante = txtEdicaoFabricante.Text;

                Produtos.RemoveAt(indice);
                Produtos.Insert(indice, p);
            }

            _ExcluirClick = false;
            AtualizarBD();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = boxEdicaoEquipamento.SelectedIndex;

            if (indice >= 0 && indice < Produtos.Count)
            {
                Produtos.RemoveAt(indice);
                boxEdicaoEquipamento.Items.RemoveAt(indice);

                txtEdicaoEquipamento.Text = "";
                txtEdicaoPrecoAquisicao.Text = "";
                txtEdicaoSerie.Text = "";
                txtEdicaoFabricante.Text = "";

                _ExcluirClick = true;
                AtualizarBD();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
        #endregion

        #region Busca de Itens
        private void boxBuscaEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = boxBuscaEquipamento.SelectedIndex;

            if (indice >= 0 && indice < Produtos.Count)
            {
                Produto p = Produtos[indice];
                
                boxBuscaEquipamento.Text = p.nomeProduto;
                txtBuscaPrecoAquisicao.Text = p.precoAquisicao;
                dateBuscaDataFabricacao.Text = p.dataFabricacao;
                txtBuscaSerie.Text = p.numeroSerie;
                txtBuscaFabricante.Text = p.Fabricante;
            }
            else
            {
                MessageBox.Show("Produto não localizado");
            }
        }
        #endregion

        private void AtualizarBD()
        {
            int indice = boxBuscaEquipamento.SelectedIndex;

            if (_ExcluirClick == true)
            {
                if (boxEdicaoEquipamento.Items.Contains(indice))
                {
                    boxEdicaoEquipamento.Items.Remove(indice);
                }
                txtEdicaoEquipamento.Text = "";
                txtEdicaoPrecoAquisicao.Text = "";
                dateEdicaoDataFabricacao.Value = DateTime.Now;
                txtEdicaoSerie.Text = "";
                txtEdicaoFabricante.Text = "";

                if (boxEdicaoEquipamento.Items.Contains(indice))
                {
                    boxBuscaEquipamento.Items.RemoveAt(indice);
                }
                boxBuscaEquipamento.Text = "";
                txtBuscaPrecoAquisicao.Text = "";
                dateBuscaDataFabricacao.Value = DateTime.Now;
                txtBuscaSerie.Text = "";
                txtBuscaFabricante.Text = "";
            }

            foreach (Produto produto in Produtos)
            {
                boxEdicaoEquipamento.Items.Add(produto.nomeProduto);
                boxBuscaEquipamento.Items.Add(produto.nomeProduto);
            }
        }
    }
}
