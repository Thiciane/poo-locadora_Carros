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
    public partial class Menuu : Form
    {
        public Menuu()
        {
            InitializeComponent();
        }

        private void lb_menu_Click(object sender, EventArgs e)
        {

        }

        private void bt_alugar_Click(object sender, EventArgs e)
        {
            Alugar alugar = new Alugar();
            alugar.ShowDialog();
        }

        private void bt_historico_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            historico.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Entidades.Cliente cliente = new Entidades.Cliente();
            lb_usuarioMen.Text = cliente.Nome;
        }

        private void lb_sairHis_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
