using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FormsIntro
{
    public partial class Form3 : Form
    {
        List<Chamados> chamados = new List<Chamados>();

        public Form3()
        {
            InitializeComponent();

            boxProtocolo.Items.Add("45664548964896");

            boxEquipamento.Items.Add("Equipamento 1");
            boxEquipamento.Items.Add("Equipamento 2");
            boxEquipamento.Items.Add("Equipamento 3");
            boxEquipamento.Items.Add("Equipamento 4");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblProtocolo.Visible = true;
            boxProtocolo.Visible = true;

            txtTituloChamado.Enabled = false;
            dateAbertura.Enabled = false;
            boxEquipamento.Enabled = false;
            txtDescricao.Enabled = false;

            int indice = boxProtocolo.SelectedIndex;
            if (indice >= 0 && indice < chamados.Count)
            {
                Chamados chamado =  chamados[indice];

                chamado.chamadoTitulo = txtTituloChamado.Text;
                chamado.chamadoDataAbertura = dateAbertura.Value;
                chamado.chamdoDescricao = txtDescricao.Text;

                chamados.RemoveAt(indice);
                chamados.Insert(indice, chamado);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblProtocolo.Visible = false;
            boxProtocolo.Visible = false;

            txtTituloChamado.Enabled = true;
            dateAbertura.Enabled = true;
            boxEquipamento.Enabled = true;
            txtDescricao.Enabled = true;
        }

        private void boxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = boxProtocolo.SelectedIndex;

            if (indice >= 0 && indice < chamados.Count)
            {
                Chamados chamado = chamados[indice];

                boxProtocolo.Text = chamado.chamadoProtocolo;
                txtTituloChamado.Text = chamado.chamadoTitulo;
                dateAbertura.Value = chamado.chamadoDataAbertura;
                txtDescricao.Text = chamado.chamdoDescricao;

                txtTituloChamado.Enabled = true;
                dateAbertura.Enabled = true;
                boxEquipamento.Enabled = true;
                txtDescricao.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtTituloChamado.Clear();
            dateAbertura.Value = DateTime.Now;
            boxEquipamento.SelectionLength = 0;
            txtDescricao.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Cadastro
            Random numCodigo = new Random();
            int codigo = numCodigo.Next();

            int Index = -1;

            foreach (Chamados c in chamados)
            {
                if (c.chamadoTitulo == txtTituloChamado.Text)
                {
                    Index = chamados.IndexOf(c);
                }
            }

            if (txtTituloChamado.Text == "" || txtDescricao.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos com informações válidas");
                txtTituloChamado.Focus();
                return;
            }

            if (dateAbertura.Value > DateTime.Now)
            {
                MessageBox.Show("Data Inválida");
                dateAbertura.Focus();
                return;
            }

            Chamados chamado = new Chamados();
            chamado.chamadoProtocolo = codigo.ToString();
            chamado.chamadoTitulo = txtTituloChamado.Text;
            chamado.chamadoDataAbertura = dateAbertura.Value;
            chamado.chamdoDescricao = txtDescricao.Text;
            

            if (Index < 0)
            {
                chamados.Add(chamado);
            }
            else
            {
                chamados[Index] = chamado;
            }

            MessageBox.Show("Cadastro efetuado com sucesso! Nº protocolo: " + codigo);
            //btnLimpar_Click(btnLimpar, EventArgs.Empty);
            #endregion
        }

        private void _ativarBotoes()
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
        }
    }
}
