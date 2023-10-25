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
    public partial class CadastrarFun : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string vendaATIVA= "";
        bool novo_usuario = false;
        public CadastrarFun()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            ListarGRIDS();
        }
        private void LimparBox()
        {
            textboxCargo.Text = "";
            textboxCelular.Text = "";
            textboxCpf.Text = "";
            textboxEmail.Text = "";
            textboxIdentificacao.Text = "";
            textboxNivel_acesso.Text = "";
            textboxNome.Text = "";
            textboxSalario.Text = "";
            textboxSenha.Text = "";
            textboxSobrenome.Text = "";
            
        }
        private void ListarGRIDS()
        {
            try
            {
                conexao.Open();
              
                
                 comando.CommandText = "SELECT pessoa.id, nome,sobrenome,cpf,celular,data_nasc,data_admissao,salario,cargo,identificacao,email,senha,nivel_acesso FROM pessoa INNER JOIN funcionario ON (funcionario.fk_pessoa = pessoa.id) WHERE ativo = 1;";
                
               
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

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
             novo_usuario = true;

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT cpf FROM pessoa WHERE cpf = '"+textboxCpf.Text +"';";

                MySqlDataReader valida_usuario = comando.ExecuteReader();

                if (valida_usuario.Read())
                {
                    novo_usuario = false;
                    MessageBox.Show("Usuário já cadastrado!");
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            // ------- //

            if (novo_usuario)
            {

                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO pessoa (nome, sobrenome, cpf, celular, data_nasc) VALUES ('"+textboxNome.Text+"', '"+textboxSobrenome.Text+"', '"+textboxCpf.Text+"', '"+textboxCelular.Text+"', '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao cadastrar novo usuário. Fale com o administrador do sistema.");
                }
                finally
                {
                    conexao.Close();
                }

                try
                {
                    conexao.Open();
                    comando.CommandText = "SELECT MAX(id) FROM pessoa;";

                    MySqlDataReader readerVENDA = comando.ExecuteReader();

                    if (readerVENDA.Read())
                    {
                        vendaATIVA = readerVENDA.GetString(0);
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


                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO funcionario (data_admissao, salario, cargo, fk_pessoa, identificacao, email, senha, nivel_acesso, ativo) VALUES (CURDATE() , '" + textboxSalario.Text+"', '"+textboxCargo.Text+"', '"+vendaATIVA+"', '"+textboxIdentificacao.Text+"', '"+textboxEmail.Text+"', '"+textboxSenha.Text+ "', '"+textboxNivel_acesso.Text+"', 's' );";
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
            }
            ListarGRIDS();
            LimparBox();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                comando.CommandText = "UPDATE pessoa SET nome= '"+textboxNome.Text+"', sobrenome= '"+textboxSobrenome.Text+"', cpf= '"+textboxCpf.Text+"', celular= '"+textboxCelular.Text+"', data_nasc='"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' WHERE id = "+dataGridView1.CurrentRow.Cells[0].Value+ " ";
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

            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE funcionario SET salario='" + textboxSalario.Text +"', cargo='"+textboxCargo.Text+"', identificacao='"+textboxIdentificacao.Text+"', email='"+textboxEmail.Text+"', senha='"+textboxSenha.Text+"', nivel_acesso='"+textboxNivel_acesso.Text+ "'  WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value + " ";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            C.ID_CadastroFun = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textboxNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textboxSobrenome.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textboxCpf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textboxCelular.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textboxSalario.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textboxCargo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textboxIdentificacao.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textboxEmail.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textboxSenha.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textboxNivel_acesso.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();

                comando.CommandText = "UPDATE funcionario SET ativo= 2 WHERE id= "+C.ID_CadastroFun+";";
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
            LimparBox();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
