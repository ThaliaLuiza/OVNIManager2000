using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIManager2000
{
    public partial class Painel : Form
    {
        //Objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDasos();
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }
        // Método para atualizar os dados:
        public void AtualizarDasos()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
            btnLigar.Enabled = !ovni.Situacao;
            btnDesligar.Enabled = ovni.Situacao;
            btnAbduzir.Enabled = ovni.Situacao;
            btnDesabduzir.Enabled = ovni.Situacao;
            btnMudar.Enabled = ovni.Situacao;
            cmbPlanetas.Enabled = ovni.Situacao;
            btnRetornarOrigem.Enabled = ovni.Situacao;
        }

        private void lblTripulantes_Click(object sender, EventArgs e)
        {

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar() == false)
            {
                MessageBox.Show("A nave já esta ligada! ");
            }
            AtualizarDasos();
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A nave já esta ligada! ");
            }
            AtualizarDasos();
        }

        private void btnAdicionarTripulante_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Limite máximo de tripulantes atingidos!");
            }
            AtualizarDasos();
        }

        private void btnRemoverTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.RemoverTripulante() == false)
            {
                MessageBox.Show("O tripulante foi removido!");
            }
            AtualizarDasos();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Situacao)
            {
                if (ovni.Abduzir() == false)
                {
                    MessageBox.Show("O tripulante foi abduzido!");
                }
                AtualizarDasos();
            }
            else
            {
                MessageBox.Show("A nave está desligada!");
            }
            AtualizarDasos();
            
        }

        private void btnDesabduzir_Click(object sender, EventArgs e)
        {
            if(ovni.Desabduzir() == false)
            {
                MessageBox.Show("O tripulante foi desabduzido!");
            }
            AtualizarDasos();
        }

        private void btnRetornarOrigem_Click(object sender, EventArgs e)
        {
            if(ovni.RetornarAoPlanetaDeOrigem() == false)
            {
                MessageBox.Show("A nave retornou ao planeta de origem");
            }
            AtualizarDasos();
            
        }
        private void btnMudar_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text) == false)
            {
                MessageBox.Show("Não foi possível mudar de planeta!");
            }
            AtualizarDasos();


        }
    }
}
