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
       /* public void Adicionar(object a, object b) //adiciona cliente
        {
            ///string nomeSenha = $"{a.ToString()} {b.ToString()}";
            //clientes.Add(nomeSenha) ;
            clientes.Add("thiciane");
            clientes.Add(123.ToString());
            clientes.Add(a.ToString());
            clientes.Add(b.ToString());
        }*/
       public void Adicionar(object a) //adiciona cliente
        {
            clientes.Add(a.ToString());
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
        private void bt_concluir_Click(object sender, EventArgs e)
        {
          
            Entidades.Cliente cliente = new Entidades.Cliente(txB_usuarioCad.Text, mk_cpf.Text, dt_nascimento.Value, mk_telefone.Text, txB_email.Text, txB_senha.Text);

            //Adicionar(cliente.Nome, cliente.Senha);
            Adicionar(cliente);
            /*foreach(string a in clientes)
            {
                MessageBox.Show(a);
            }*/

            foreach (string a in clientes)
            {
                if (Object.Equals(a, cliente))
                {
                    MessageBox.Show("Opa! parece que você já tem cadastro.");

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
