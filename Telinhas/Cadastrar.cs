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
        public void Adicionar(object a, object b)
        {
            clientes.Add(a.ToString());
            clientes.Add("thiciane");
            clientes.Add("nicoly");
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
        private void bt_concluir_Click(object sender, EventArgs e)
        {
          
            Entidades.Cliente cliente = new Entidades.Cliente(txB_usuarioCad.Text, mk_cpf.Text, dt_nascimento.Value, mk_telefone.Text, txB_email.Text, txB_senha.Text);

            Adicionar(cliente.Nome, cliente.Senha);
            /*foreach(string a in clientes)
            {
                MessageBox.Show(a);
            }*/

            foreach (string a in clientes)
            {
                if (cliente.Nome.Equals(a))
                {
                    if (cliente.Senha.Equals(a))
                    {
                        MessageBox.Show("Opa! parece que você já tem cadastro.");
                    }
                }
                else
                {
                    Menuu m = new Menuu();
                    m.ShowDialog();
                }
            }
            
        }
    }
}
