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
    public partial class Venda2 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Venda2()
        {
            InitializeComponent(); 
            servidor = "Server=localhost;Database=rainbowscream;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            C.gridEscolha = 1;
            gridEscolha();
            
            
        }
        private void gridEscolha()
        {

            if (C.gridEscolha == 2)
            {

                dataGridViewRecipientes.Visible = false;
                labelRecipientes.Visible = false;

                dataGridView1.Visible = true;
                labelSabor.Visible = true;

                dataGridViewAdicionais.Visible = false;
                labelAdicionais.Visible = false;

                GridSabor();
            }
            else if (C.gridEscolha == 3)
            {

                dataGridViewRecipientes.Visible = false;
                labelRecipientes.Visible = false;

                dataGridView1.Visible = false;
                labelSabor.Visible = false;

                dataGridViewAdicionais.Visible = true;
                labelAdicionais.Visible = true;
                GridAdicionar();
            }
            else if (C.gridEscolha == 1)
            {
                

                dataGridViewRecipientes.Visible = true;
                labelRecipientes.Visible=true;

                dataGridView1.Visible = false;
                labelSabor.Visible = false;

                dataGridViewAdicionais.Visible = false;
                labelAdicionais.Visible =false;
                GridRecipientes();

            }

        }


        private void GridAdicionar()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT id, adicionais, preco FROM adicionais";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridViewAdicionais.DataSource = tabelaGRID;

                dataGridViewAdicionais.Columns["id"].HeaderText = "ID";
                dataGridViewAdicionais.Columns["adicionais"].HeaderText = "Adicionais";
                dataGridViewAdicionais.Columns["preco"].HeaderText = "preco";
                



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
        private void GridSabor()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT id, descricao, sabor, preco FROM  "+C.grid+"  ";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridView1.DataSource = tabelaGRID;

                dataGridView1.Columns["id"].HeaderText = "ID";
                dataGridView1.Columns["descricao"].HeaderText = "Descrição";
                dataGridView1.Columns["sabor"].HeaderText = "Sabor";
                dataGridView1.Columns["preco"].HeaderText = "Preço";



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
        private void GridRecipientes()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT id, tipo , tamanho FROM recipientes";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridViewRecipientes.DataSource = tabelaGRID;

                dataGridViewRecipientes.Columns["id"].HeaderText = "ID";
                dataGridViewRecipientes.Columns["tipo"].HeaderText = "Tipo";
                dataGridViewRecipientes.Columns["tamanho"].HeaderText = "Tamanho";



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
        private void Gridvenda()
        {
            try
            {
                conexao.Open();


                comando.CommandText = "SELECT "+C.gridSabor+" "+C.gridAdicionais+" "+C.gridRecipientes+"  FROM venda_itens INNER JOIN acai ON (venda_itens.fk_acai = acai.id) INNER JOIN adicionais ON (venda_itens.fk_adicionais = adicionais.id) INNER JOIN casquinha ON (venda_itens.fk_casquinha = casquinha.id) INNER JOIN especiais  ON (venda_itens.fk_especiais = especiais.id) INNER JOIN massa ON (venda_itens.fk_massa = massa.id) INNER JOIN picole ON (venda_itens.fk_picole = picole.id) INNER JOIN recipientes ON (venda_itens.fk_recipientes = recipientes.id) INNER JOIN sundae_milkshake ON (venda_itens.fk_sundae = sundae_milkshake.id) WHERE fk_venda = " + C.vendaATIVA+"";


                MySqlDataAdapter adaptadorGRID = new MySqlDataAdapter(comando);
                DataTable tabelaGRID = new DataTable();
                adaptadorGRID.Fill(tabelaGRID);
                dataGridViewVenda.DataSource = tabelaGRID;
                if (C.gridEscolha == 2)
                {
                    dataGridViewVenda.Columns[""+C.grid+".id"].HeaderText = "ID";
                    dataGridViewVenda.Columns["" + C.grid + ".descricao"].HeaderText = "Descrição";
                    dataGridViewVenda.Columns["" + C.grid + ".sabor"].HeaderText = "Sabor";
                    dataGridViewVenda.Columns["" + C.grid + ".preco"].HeaderText = "Preço";
                }else if (C.gridEscolha == 3)
                {
                    dataGridViewVenda.Columns["adicionais.id"].HeaderText = "ID";
                    dataGridViewVenda.Columns["adicionais.adicionais"].HeaderText = "Adicionais";
                    dataGridViewVenda.Columns["adicionais.preco"].HeaderText = "Preço";
                }else if (C.gridEscolha == 1)
                {
                    dataGridViewVenda.Columns["recipientes.id"].HeaderText = "ID";
                    dataGridViewVenda.Columns["recipientes.tipo"].HeaderText = "Tipo";
                    dataGridViewVenda.Columns["recipientes.tamanho"].HeaderText = "Tamanho";
                    
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



        private void panel1_Paint(object sender, PaintEventArgs e)
        {










        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE venda_itens SET  fk_" + C.grid + " =" + dataGridView1.CurrentRow.Cells[0].Value + "WHERE fk_venda ="+C.vendaATIVA+"";
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

            C.gridSabor = "" + C.grid + ".id , fk_" + C.grid + ".descricao, fk_" + C.grid + ".sabor, fk_" + C.grid + ".preco ";

            Gridvenda();

        }

        private void dataGridViewAdicionais_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE venda_itens SET  fk_adicionais =" + dataGridViewAdicionais.CurrentRow.Cells[0].Value + "WHERE fk_venda =" + C.vendaATIVA + ";";
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

            C.gridAdicionais = "adicionais.id, adicionais.adicionais, adicionais.preco";

            Gridvenda();

        }

        private void dataGridViewRecipientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE venda_itens SET  fk_recipientes =" + dataGridViewRecipientes.CurrentRow.Cells[0].Value + " WHERE fk_venda =" + C.vendaATIVA + ";";
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

            C.gridRecipientes = "recipientes.id, recipientes.tipo, recipientes.tamanho";

            Gridvenda();

        }

        private void dataGridViewRecipientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAdicionais_Click(object sender, EventArgs e)
        {

        }

        private void labelRecipientes_Click(object sender, EventArgs e)
        {

        }

        private void labelSabor_Click(object sender, EventArgs e)
        {

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            C.gridEscolha++;
            gridEscolha();
        }
    }
}
