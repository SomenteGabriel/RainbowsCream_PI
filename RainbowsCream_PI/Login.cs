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
    public partial class Login : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Login()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
        

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT email, senha , nivel_acesso FROM funcionario WHERE email = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    C.nivel_acesso = resultado.GetString("nivel_acesso");

                    this.Hide();
                    Form TelaPrincipal = new Principal();
                    TelaPrincipal.FormClosed += (s, args) => this.Close();
                    TelaPrincipal.Show();

                    



                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos!");
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
            textBoxSENHA.Text = "";
            textBoxUSUARIO.Text = "";

        }
    }
}
