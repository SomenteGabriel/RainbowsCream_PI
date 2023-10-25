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
    public partial class CadastroAdi : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public CadastroAdi()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ListarGRIDS();

        }
        private void LimparBox()
        {
            textboxAdicionais.Text = "";
            textboxQuantidade.Text = "";
        }
        private void ListarGRIDS()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT * FROM adicionais";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridView1.DataSource = tabelaGRID;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["adicionais"].HeaderText = "Adicional";
                dataGridView1.Columns["quantidade_kg"].HeaderText = "Quantidade";
                



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

        private void CadastroAdi_Load(object sender, EventArgs e)
        {

        }
        

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO adicionais (adicionais, quantidade_kg) VALUES ('" + textboxAdicionais.Text + "', '" + textboxQuantidade.Text + "');";
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

        private void buttonAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE adicionais SET adicionais='" + textboxAdicionais.Text + "', quantidade_kg='" + textboxQuantidade.Text + "'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value + " ";
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

        private void buttonDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM adicionais WHERE id='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
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

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            C.ID_CadastroFun = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textboxAdicionais.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxQuantidade.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
