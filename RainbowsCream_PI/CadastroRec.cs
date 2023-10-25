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
    public partial class CadastroRec : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public CadastroRec()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ListarGRIDS();
        }
        private void LimparBox()
        {
            textboxQuantidade.Text = "";
            textboxRecipiente.Text = "";
            textBoxTamanho.Text = "";
        }
        private void ListarGRIDS()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT * FROM recipientes";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridView1.DataSource = tabelaGRID;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["tipo"].HeaderText = "Tipo";
                dataGridView1.Columns["quantidade_n"].HeaderText = "Quantidade";
                dataGridView1.Columns["tamanho"].HeaderText = "Tamanho";



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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO recipientes (tipo, quantidade_n, tamanho) VALUES ('" + textboxRecipiente.Text + "', '" + textboxQuantidade.Text + "', '"+textBoxTamanho.Text+"');";
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
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE recipientes SET tipo='" + textboxRecipiente.Text + "', quantidade_n='" + textboxQuantidade.Text + "', tamanho='"+textBoxTamanho.Text+"'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value + " ";
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
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM recipientes WHERE id='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
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
            textboxRecipiente.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxQuantidade.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTamanho.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void CadastroRec_Load(object sender, EventArgs e)
        {

        }
    }
}
