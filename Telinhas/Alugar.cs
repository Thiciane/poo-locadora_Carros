using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraCarros.Telinhas
{
    public partial class Alugar : Form
    {
        public List<string> carros = new List<string>();
        public Alugar()
        {
            InitializeComponent();
        }

        private void lb_devolucao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_usuarioHis_Click(object sender, EventArgs e)
        {

        }

        private void cB_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cB_marca.Text == "Chevrolet")
            {
               string[] Chevrolet = { "ONIX", "MONTANA", "S10 HIGH COUNTRY", "S10 CABINE DUPLA", "EQUINOX" };
               cB_modelo.Items.AddRange(Chevrolet);
                
            }
            else if (cB_marca.Text == "Fiat")
            {
                string[] Fiat = { "TORO", "MOBI", "CRONOS", "UNO", "GRAND", "SIENA" };
                cB_modelo.Items.AddRange(Fiat);
            }
            else if (cB_marca.Text == "Ford")
            {
                string[] Ford = { "RANGER", "TERRITORY", "BRONCO SPORT", "MAVERICK" };
                cB_modelo.Items.AddRange(Ford);
            }
            else if (cB_marca.Text == "Peugeut")
            {
                string[] Peugeut = { "208 LIKE", "208 ACTIVE", "3008", "e-208" };
                cB_modelo.Items.AddRange(Peugeut);
            }
            else if (cB_marca.Text == "Reno")
            {
                string[] Reno = {"DUSTER", "LOGAN", "CAPTUR", "KWID", "SANDERO" };
                cB_modelo.Items.AddRange(Reno);
            }
            else if (cB_marca.Text == "Volkswagen")
            {
                string[] Volkswagen = { "GOL", "SAVEIRO", "T-CROSS", "AMAROK", "NIVUS" };
                cB_modelo.Items.AddRange(Volkswagen);
            }
        }

        private void cB_marca_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            string[] carrosArray = { cB_marca.Text, cB_modelo.Text, cB_ano.Text, cB_cor.Text };
            carros.AddRange(carrosArray);
            MessageBox.Show("Carro alugado com sucesso!");
        }

        private void lb_sairHis_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void Alugar_Load(object sender, EventArgs e)
        {
            Entidades.Cliente cliente = new Entidades.Cliente();

            lb_usuarioAlu.Text = cliente.Nome;
        }
    }
}
