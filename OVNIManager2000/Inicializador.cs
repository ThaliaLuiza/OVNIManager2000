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
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void lblPlanetaDeOrigem_Click(object sender, EventArgs e)
        {

        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // obter as informações do forms: 
            int maxTripulantes = (int)nudTripulantes.Value;
            int maxAbduzidos = (int)nudAbduzidos.Value;
            string planetaOrigem = cmbPlaneta.Text;

            // Instanciar o OVNI:
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(maxTripulantes, maxAbduzidos, planetaOrigem);


            // Abrir a janela do painel:

            Painel janela = new Painel(ovni);
            // Abrir janela:
            janela.ShowDialog();
         
        }
    }
}
