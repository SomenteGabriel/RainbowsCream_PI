using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RainbowsCream_PI
{
    public partial class CadastroSor : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        int x = 0;
        string frase = "";
        string frase2 = "";
        string frase3 = "";
        public CadastroSor()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ListarGRIDS();
            mudanca();
        }

        private void mudanca()
        {
            
           if (C.Produto == "casquinha" || C.Produto == "sundae_milkshake" || C.Produto == "especiais")
            {
                textboxQuantidade.Visible = false;
                labelQuantidade.Visible = false;

                labelPreco.Location = new Point(284, 156);
                textBoxPreco.Location = new Point(197, 178);

            }

           if (C.Produto != "picole")
            {
                labelMarca.Visible = false;
                textBoxMarca.Visible=false;

            }

           if (C.Produto == "picole")
            {
                labelQuantidade.Text = "Quantidade em Unid.";
                frase = ", quantidade, marca";
                frase2 = "'" + textboxQuantidade.Text + "' , '"+textBoxMarca.Text+"'";
                frase3 = ", quantidade= '" + textboxQuantidade.Text + "', marca='"+textBoxMarca.Text+"'";
            }
           
           if (C.Produto == "acai" || C.Produto == "massa")
            {
                labelQuantidade.Text = "Quantidade em Kg.";
                frase = ", quantidade";
                frase2 = "'"+textboxQuantidade.Text+"'";
                frase3 = ", quantidade= '" + textboxQuantidade.Text + "'";
            }

        }

        private void LimparBox()
        {
            textboxQuantidade.Text = "";
            textboxSabor.Text = "";
            textBoxDescricao.Text = "";
            textBoxMarca.Text = "";
            textBoxPreco.Text = "";
           
        }

        private void ListarGRIDS()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT * FROM "+C.Produto+ "  WHERE ativo=1;";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridView1.DataSource = tabelaGRID;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["descricao"].HeaderText = "Descrição";
                dataGridView1.Columns["sabor"].HeaderText = "Sabor";
                dataGridView1.Columns["preco"].HeaderText = "Preço";
                if (C.Produto != "casquinha" || C.Produto != "sundae_milkshake" || C.Produto != "especiais")
                {
                    dataGridView1.Columns["quantidade"].HeaderText = "Quantidade";
                }
                if (C.Produto == "picole")
                {
                    dataGridView1.Columns["marca"].HeaderText = "Marca";
                }


            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            mudanca();



            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO "+C.Produto+"  (descricao,sabor, preco, ativo "+frase+" ) VALUES ('"+textBoxDescricao.Text+"', '"+textboxSabor.Text+"', '"+textBoxPreco.Text+"', 1, "+frase2+" );";
                comando.ExecuteNonQuery();
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar novo usuário. Fale com o administrador do sistema.");
            }
            finally
            {
                conexao.Close();
            }
            ListarGRIDS();
           
            LimparBox();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            mudanca();
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE "+C.Produto+" SET descricao = '"+textBoxDescricao.Text+"',sabor='"+textboxSabor.Text+"', preco= '"+textBoxPreco.Text.Replace(",", ".") + "'  "+frase3+"  WHERE id = " + C.id_produto + " ";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            ListarGRIDS();
            
            LimparBox();
            
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            mudanca();
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE "+C.Produto+" SET ativo=2 WHERE id='"+ C.id_produto + "'";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            ListarGRIDS();
            
            LimparBox();
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            C.ID_CadastroFun = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDescricao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxSabor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPreco.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textboxQuantidade.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxMarca.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();


        }

        private void CadastroSor_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void labelQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}
