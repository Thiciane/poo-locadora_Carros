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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            Entidades.Cliente cliente = new Entidades.Cliente();

            lb_usuarioHis.Text = cliente.Nome;
        }

        private void lb_usuarioHis_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alugar alugar = new Alugar();
            int index = dataGridView1.CurrentCell.RowIndex;
            alugar.carros.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = alugar.carros;
        }

        private void lb_sairHis_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menuu menuu = new Menuu();
            menuu.ShowDialog();
        }
    }
}
