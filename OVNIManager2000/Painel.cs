﻿using System;
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
    }
}
