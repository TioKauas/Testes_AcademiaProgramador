using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace Teste_1
{
    public partial class Teste1 : Form
    {
        public Teste1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Esq, Dir, Inf;
            int Conta1, Conta2, Conta3;

            if (txtDireita.Text == "" || txtEsquerda.Text == "" || txtInferior.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else 
            {
                if (Int32.TryParse(txtDireita.Text, out Dir) && Int32.TryParse(txtEsquerda.Text, out Esq) && Int32.TryParse(txtInferior.Text, out Inf))
                {
                    Dir = Convert.ToInt32(txtDireita.Text);
                    Esq = Convert.ToInt32(txtDireita.Text);
                    Inf = Convert.ToInt32(txtInferior.Text);

                    Conta1 = Esq + Dir;
                    Conta2 = Inf + Dir;
                    Conta3 = Esq + Inf;

                     if (Conta1 <= Inf || Conta2 <= Esq || Conta3 <= Dir)
                    {
                        MessageBox.Show("Valores Inválidos: É necessário que a medida de " +
                            "qualquer um dos lados seja menor que a soma dos outros dois lados");
                        return;
                    }   

                    #region Tipos de Triângulos
                    if (Dir == Esq && Dir == Inf)
                    {
                        picImage.ImageLocation = @"C:\Users\ramos\OneDrive\Documentos\MeuPC\Testes AP\Teste 1\Teste 1\Resources\Isóceles.png";
                        picImage.Location = new Point(245, 48);
                        picImage.Size = new Size(180, 135);

                        lblDescricao.Text = "Dois lados iguais e os ângulos opostos.";
                        lblDescricao.Location = new Point(180, 194);
                        lblDescricao.Font = new Font("MicrosoftSansSerift", 7, FontStyle.Bold);
                        MessageBox.Show("AAAAAAAAAAAAAAAAAAAAAAA");
                    }
                    else if (Esq == Inf && Dir == Inf && Esq == Dir)
                    {
                        picImage.ImageLocation = @"C:\Users\ramos\OneDrive\Documentos\MeuPC\Testes AP\Teste 1\Teste 1\Resources\Equilátero.png";
                        picImage.Location = new Point(248, 48);
                        picImage.Size = new Size(180, 135);

                        lblDescricao.Text = "Todos os lados e ângulos iguais.";
                        lblDescricao.Location = new Point(180, 194);
                        lblDescricao.Font = new Font("MicrosoftSansSerift", 7, FontStyle.Bold);
                    }
                    else if (Dir != Esq && Dir != Inf && Esq != Inf)
                    {
                        picImage.ImageLocation = @"C:\Users\ramos\OneDrive\Documentos\MeuPC\Testes AP\Teste 1\Teste 1\Resources\Escaleno.png";
                        picImage.Location = new Point(230, 48);
                        picImage.Size = new Size(180, 135);

                        lblDescricao.Text = "Todos os lados e ângulos são diferentes.";
                        lblDescricao.Location = new Point(180, 194);
                        lblDescricao.Font = new Font("MicrosoftSansSerift", 7, FontStyle.Bold);
                    }
                    else
                    {
                        MessageBox.Show("Nada encontrando");
                    }
                    #endregion

                    picImage.Visible = true;
                    btnLimpar.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("Preencha os campos com valores válidos");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDireita.Text = "";
            txtEsquerda.Text = "";  
            txtInferior.Text = "";

            picImage.Visible = false;
            btnLimpar.Enabled = false;
        }
    }
}
