using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowsCream_PI
{
    public partial class Principal : Form
    {
            
        public Principal()
        {
            InitializeComponent();

            validalogin();
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

        private void validalogin()
        {

         

            if (C.nivel_acesso != "adm")
            {
                cadastrarToolStripMenuItem.Visible = false;

            }
            else
            {
                
                
            }

            if (C.nivel_acesso != "gerente" && C.nivel_acesso != "adm")
            {
                produtosToolStripMenuItem1.Visible = false;
            }




        }



        private void Principal_Load(object sender, EventArgs e)
        {

        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            Form telaCADASTRO = new CadastrarFun();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void gerenciarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void funcionariosInativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            Form telaCADASTRO = new FunInativos();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            Form telaCADASTRO = new CadastroRec();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            Form telaCADASTRO = new CadastroAdi();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void picoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "picole";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           
        }

        private void casquinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "casquinha";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
            
        }

        private void sundaeEMilkshakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "sundae_milkshake";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           
        }

        private void açaíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "acai";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           
        }

        private void massaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "massa";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           
        }

        private void especiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "especiais";
            Form telaCADASTRO = new CadastroSor();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
           
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            C.Produto = "especiais";
            Form telaCADASTRO = new Venda();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();
        }
    }
}



