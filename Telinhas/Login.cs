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
            if (Entrar(txB_usuario.Text, txB_senha.Text) != true)
            {
                MessageBox.Show("senha incorreta");
                txB_usuario.Text = String.Empty;
                txB_senha.Text = String.Empty;
            }
            else
            {
                Menuu menuu = new Menuu();
                menuu.ShowDialog();
            }
            
        }
        public bool Entrar (string nome, string senha)
        {
            bool boole = true;
            /*foreach (string a in Cadastrar.Adicionar())
            {
                if (nome.Equals(a))
                {
                    if (senha.Equals(a))
                    {
                        boole = true;
                    }
                }
                else
                {
                    boole = false;
                }
            }*/
            return boole;
        }
    }
}
