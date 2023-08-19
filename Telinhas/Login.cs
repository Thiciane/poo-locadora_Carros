using LocadoraCarros.Telinhas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraCarros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lb_usuarioLog.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lb_senha.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            txB_senha.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            txB_usuario.Anchor = AnchorStyles.Right | AnchorStyles.Left;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            Menuu menuu = new Menuu();
            menuu.ShowDialog();
        }
    }
}
