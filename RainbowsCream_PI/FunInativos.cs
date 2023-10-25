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
    public partial class FunInativos : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FunInativos()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ListarGRIDS();
        }

        private void ListarGRIDS()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT pessoa.id, nome,sobrenome,cpf,celular,data_nasc,data_admissao,salario,cargo,identificacao,email,senha,nivel_acesso FROM pessoa INNER JOIN funcionario ON (funcionario.fk_pessoa = pessoa.id) WHERE ativo = 2;";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridView1.DataSource = tabelaGRID;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["nome"].HeaderText = "Nome";
                dataGridView1.Columns["sobrenome"].HeaderText = "Sobrenome";
                dataGridView1.Columns["cpf"].HeaderText = "CPF";
                dataGridView1.Columns["celular"].HeaderText = "Celular";
                dataGridView1.Columns["data_nasc"].HeaderText = "Data de nascimento";
                dataGridView1.Columns["data_admissao"].HeaderText = "data de admissão";
                dataGridView1.Columns["salario"].HeaderText = "Salario";
                dataGridView1.Columns["cargo"].HeaderText = "Cargo";
                dataGridView1.Columns["identificacao"].HeaderText = "Identificação";
                dataGridView1.Columns["email"].HeaderText = "Email";
                dataGridView1.Columns["senha"].HeaderText = "Senha";
                dataGridView1.Columns["nivel_acesso"].HeaderText = "Nivel de acesso";



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
           
            try
            {
               conexao.Open();

               comando.CommandText = "UPDATE funcionario SET ativo= 1 WHERE id= " + C.ID_CadastroFun + ";";
               comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            ListarGRIDS();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
         
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            C.ID_CadastroFun = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
