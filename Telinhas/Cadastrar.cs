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
    public partial class Cadastrar : Form
    {
        public List<string> clientes = new List<string>();

        public Cadastrar()
        {
            InitializeComponent();
        }
        public void Adicionar(object a)
        {
            //clientes.Add(a);
            clientes.Add(a.ToString());
        }

        private void lb_marca_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            Entidades.Cliente cliente = new Entidades.Cliente(txB_usuarioCad.Text, mk_cpf.Text, dt_nascimento.Value, mk_telefone.Text, txB_email.Text, txB_senha.Text);
            Adicionar(cliente);
        }
    }
}
