using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LocadoraCarros.Telinhas
{
    public partial class Alugar : Form
    {
        List<Entidades.Carros> carrosList = new List<Entidades.Carros>();
        Entidades.Carros carro = new Entidades.Carros();
        
        
        string filePath = @"C:\Users\thici\Desktop\file.xml";

        XmlDocument xmlDoc = new XmlDocument();
        private XmlElement root;

        //XmlElement marcaElement = xmlDoc.CreateElement("Marca");

        public Alugar()
        {
            InitializeComponent();
            this.dataGridView1.Font = new Font("Arial Rounded MT", 12);

            root = xmlDoc.CreateElement("Dados");
            //root = xmlDoc.
            xmlDoc.AppendChild(root);
        }

        private void cB_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_marca.Text == "Chevrolet")
            {
                string[] Chevrolet = { "ONIX", "MONTANA", "S10 HIGH COUNTRY", "S10 CABINE DUPLA", "EQUINOX" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Chevrolet);

            }
            else if (cB_marca.Text == "Fiat")
            {
                string[] Fiat = { "TORO", "MOBI", "CRONOS", "UNO", "GRAND", "SIENA" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Fiat);
            }
            else if (cB_marca.Text == "Ford")
            {
                string[] Ford = { "RANGER", "TERRITORY", "BRONCO SPORT", "MAVERICK" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Ford);
            }
            else if (cB_marca.Text == "Peugeot")
            {
                string[] Peugeut = { "208 LIKE", "208 ACTIVE", "3008", "e-208" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Peugeut);
            }
            else if (cB_marca.Text == "Reno")
            {
                string[] Reno = { "DUSTER", "LOGAN", "CAPTUR", "KWID", "SANDERO" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Reno);
            }
            else if (cB_marca.Text == "Volkswagen")
            {
                string[] Volkswagen = { "GOL", "SAVEIRO", "T-CROSS", "AMAROK", "NIVUS" };
                cB_modelo.Items.Clear();
                cB_modelo.Text = String.Empty;
                cB_modelo.Items.AddRange(Volkswagen);
            }
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            carro.Marca = cB_marca.Text;
            carro.Modelo = cB_modelo.Text;
            carro.Ano = Convert.ToInt32(cB_ano.Text);
            carro.Cor = cB_cor.Text;
            carro.Valor = carro.Calculo(cB_dias.Text);


            carrosList.Add(carro);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = carrosList;


            try
            {
                /*
                // Cria um novo documento XML
                //XmlDocument xmlDoc = new XmlDocument();

                // Cria o elemento raiz
                XmlElement root = xmlDoc.CreateElement("Dados");
                xmlDoc.AppendChild(root);

                // Cria e adiciona elementos filhos com os dados
                XmlElement marcaElement = xmlDoc.CreateElement("Marca");
                marcaElement.InnerText = cB_marca.Text;
                root.AppendChild(marcaElement);

                XmlElement modeloElement = xmlDoc.CreateElement("Modelo");
                modeloElement.InnerText = cB_modelo.Text;
                root.AppendChild(modeloElement);

                XmlElement anoElement = xmlDoc.CreateElement("Ano");
                anoElement.InnerText = cB_ano.Text;
                root.AppendChild(anoElement);

                XmlElement corElement = xmlDoc.CreateElement("Cor");
                corElement.InnerText = cB_cor.Text;
                root.AppendChild(corElement);

                // Mostra a ligação da seleção de pasta
                //FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                //folderDialog.Description = "Selecione a pasta para salvar o arquivo XML.";

                //if (folderDialog.ShowDialog() == DialogResult.OK)
                //{
                //string selectedPath = folderDialog.SelectedPath;
                //string filePath = Path.Combine(selectedPath, "dados.xml");

                    //Salvar o documento XML na pasta escolhida pelo usuário
                    xmlDoc.Save(filePath);
                */
                //if(salvando)
                //{
                Salvando(root);
                xmlDoc.Save("\n" + filePath);

                MessageBox.Show("Dados salvos com sucesso!");

                //}
                //}


                /*//Antes de salvar o XML eu salvo o objeto no banco e logo após eu faço uma busca e atribuo a uma list:

                List<Local> locais= new ArrayList<Local>();
                for (Local local : localNegocio.buscarTodos()) {
			                locais.add(local);
		                }
                //Depois eu serializo os dados passando a list atual e salvo o XML, substituindo o antigo:

                XStream x = new XStream();
                x.autodetectAnnotations(true);
                x.alias("local", Local.class);

                String xml = x.toXML(locais);
                System.out.println(xml);
                salvarArquivo(xml, "local.xml");*/


                /*
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "dados.xml");

                 dados;

                if (File.Exists(filePath))
                {
                    // Carregar dados existentes
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                        dados = (Dados)serializer.Deserialize(fileStream);
                    }
                }
                else
                {
                    dados = new Carros();


                    // Adicionar novos dados
                    dados.Marca = cB_marca.Text;
                    dados.Modelo = cB_modelo.Text;
                    dados.Ano = cB_ano.Text;
                    dados.Cor = cB_cor.Text;

                    // Salvar os dados
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                        serializer.Serialize(fileStream, dados);
                    }

                    MessageBox.Show("Dados salvos com sucesso!");

                }*/


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDesculpe, ocorreu um erro inesperado") ;
            }

            
        }

        private void Alugar_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var xmlDocument = new XDocument(
                new XElement("Dados",
                    dataGridView1.Rows.Cast<DataGridViewRow>()
                        .Select(row =>
                            new XElement("Item",
                                $"{row.Cells["Marca"].Value}, {row.Cells["Modelo"].Value}, {row.Cells["Ano"].Value}, {row.Cells["Cor"].Value}"))));


            //lbDados.Items.Clear();
            lbDados.Items.AddRange(xmlDocument.Descendants("Item").Select(item => item.Value + "\n").ToArray());
        }

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            cB_marca.Text = String.Empty;
            cB_modelo.Text = String.Empty;
            cB_ano.Text = String.Empty;
            cB_cor.Text = String.Empty;
            cB_dias.Text = String.Empty;


            int index = dataGridView1.CurrentCell.RowIndex;
            carrosList.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = carrosList;
        }

        private void Salvando(XmlElement root)
        {


            // Cria e adiciona elementos filhos com os dados
            XmlElement marcaElement = xmlDoc.CreateElement("Marca");
            marcaElement.InnerText = cB_marca.Text;
            root.AppendChild(marcaElement);

            XmlElement modeloElement = xmlDoc.CreateElement("Modelo");
            modeloElement.InnerText = cB_modelo.Text;
            root.AppendChild(modeloElement);

            XmlElement anoElement = xmlDoc.CreateElement("Ano");
            anoElement.InnerText = cB_ano.Text;
            root.AppendChild(anoElement);

            XmlElement corElement = xmlDoc.CreateElement("Cor");
            corElement.InnerText = cB_cor.Text;
            root.AppendChild(corElement);

            //Salvar o documento XML na pasta escolhida pelo usuário
            //xmlDoc.Save(filePath);
        }
    }
    
}
