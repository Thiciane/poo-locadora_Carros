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
        string[] Thici = { "thiciane", "1234", "20/06/2006", "(69) 99246-9166", "thici.com", "123" };
        


        public Cadastrar()
        {
            InitializeComponent();
        }

       public void Adicionar(object a) //adiciona cliente
        {
            //clientes.Add(Thici);
            clientes.Add(a.ToString());
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
        private void bt_concluir_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Cliente cliente = new Entidades.Cliente(txB_usuarioCad.Text, mk_cpf.Text, dt_nascimento.Value, mk_telefone.Text, txB_email.Text, txB_senha.Text);

                Adicionar(cliente);

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
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
          

            
        }
    }
}
