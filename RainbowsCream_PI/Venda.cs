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
    public partial class Venda : Form
    {
        int confirmar = 0;
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string id_funcionario = "";
        public Venda()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }
        private void iniciarvenda()
        {
             confirmar = 0;
            if (textBox1.Text != "")
            {
                try
                {

                    conexao.Open();
                    comando.CommandText = "SELECT id FROM funcionario WHERE identificacao = " + textBox1.Text + "";
                    MySqlDataReader readerVENDA = comando.ExecuteReader();

                    if (readerVENDA.Read())
                    {
                        id_funcionario = readerVENDA.GetString(0);

                        confirmar = 1;

                    }
                    else
                    {
                        confirmar = 3;

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
            else
            {
                MessageBox.Show(" Código de funcionário não pode ser vazio ");
            }


            if (confirmar == 1)
            {
                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO venda (data_hora, fk_funcionario) VALUES ('" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " + id_funcionario + " );";
                    comando.ExecuteNonQuery();
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
                    comando.CommandText = "SELECT MAX(id) FROM venda;";

                    MySqlDataReader readerVENDA = comando.ExecuteReader();

                    if (readerVENDA.Read())
                    {
                        C.vendaATIVA = readerVENDA.GetString(0);
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
                    comando.CommandText = "INSERT INTO venda_itens (fk_venda) VALUES ("+C.vendaATIVA+")";
                    comando.ExecuteNonQuery();
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
            else
            {
                if (confirmar == 3)
                {
                    textBox1.Text = "";
                    MessageBox.Show("Numero de identificação incorreto, insira novamante");

                }
            }
        }

        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPicole_Click(object sender, EventArgs e)
        {

            iniciarvenda();

            if (confirmar == 1)
            {
                
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "picole";
        }

        private void pictureBoxMilkshake_Click(object sender, EventArgs e)
        {
            iniciarvenda();
            if (confirmar == 1)
            {
               
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "sundae_milkshake";
        }

        private void pictureBoxCasquinha_Click(object sender, EventArgs e)
        {
            iniciarvenda();
            if (confirmar == 1)
            {
                
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "casquinha";
        }

        private void pictureBoxMassa_Click(object sender, EventArgs e)
        {
            iniciarvenda();
            if (confirmar == 1)
            {
               
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "massa";
        }

        private void pictureBoxEspeciais_Click(object sender, EventArgs e)
        {
            iniciarvenda();
            if (confirmar == 1)
            {
               
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "especiais";
        }

        private void pictureBoxAcai_Click(object sender, EventArgs e)
        {
            iniciarvenda();
            if (confirmar == 1)
            {
                
                FecharFormulariosFilhos();
                Form telaCADASTRO = new Venda2();
                telaCADASTRO.Show();
            }
            C.grid = "acai";
        }
    }
}
