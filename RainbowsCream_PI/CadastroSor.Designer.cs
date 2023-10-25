namespace RainbowsCream_PI
{
    partial class CadastroSor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textboxQuantidade = new System.Windows.Forms.TextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textboxSabor = new System.Windows.Forms.TextBox();
            this.labelSabor = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(584, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 438);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textboxQuantidade
            // 
            this.textboxQuantidade.Location = new System.Drawing.Point(65, 178);
            this.textboxQuantidade.Name = "textboxQuantidade";
            this.textboxQuantidade.Size = new System.Drawing.Size(243, 20);
            this.textboxQuantidade.TabIndex = 3;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.BackColor = System.Drawing.Color.White;
            this.labelQuantidade.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelQuantidade.Location = new System.Drawing.Point(121, 156);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(136, 19);
            this.labelQuantidade.TabIndex = 29;
            this.labelQuantidade.Text = "Quantidade em unid";
            this.labelQuantidade.Click += new System.EventHandler(this.labelQuantidade_Click);
            // 
            // textboxSabor
            // 
            this.textboxSabor.Location = new System.Drawing.Point(323, 54);
            this.textboxSabor.Name = "textboxSabor";
            this.textboxSabor.Size = new System.Drawing.Size(243, 20);
            this.textboxSabor.TabIndex = 2;
            // 
            // labelSabor
            // 
            this.labelSabor.AutoSize = true;
            this.labelSabor.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSabor.Location = new System.Drawing.Point(410, 32);
            this.labelSabor.Name = "labelSabor";
            this.labelSabor.Size = new System.Drawing.Size(49, 19);
            this.labelSabor.TabIndex = 28;
            this.labelSabor.Text = "Sabor";
            this.labelSabor.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Exotc350 Bd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Image = global::RainbowsCream_PI.Properties.Resources.registro__1_;
            this.buttonCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCadastrar.Location = new System.Drawing.Point(197, 392);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(106, 31);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDeletar.FlatAppearance.BorderSize = 0;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Font = new System.Drawing.Font("Exotc350 Bd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Image = global::RainbowsCream_PI.Properties.Resources.lixo;
            this.buttonDeletar.Location = new System.Drawing.Point(270, 445);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(96, 31);
            this.buttonDeletar.TabIndex = 8;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Font = new System.Drawing.Font("Exotc350 Bd BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Image = global::RainbowsCream_PI.Properties.Resources.atualizar__2_;
            this.buttonAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAtualizar.Location = new System.Drawing.Point(340, 392);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(110, 31);
            this.buttonAtualizar.TabIndex = 7;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(65, 54);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(243, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.Location = new System.Drawing.Point(152, 32);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(75, 19);
            this.labelDescricao.TabIndex = 31;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(323, 178);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(243, 20);
            this.textBoxPreco.TabIndex = 4;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(410, 156);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(49, 19);
            this.labelPreco.TabIndex = 33;
            this.labelPreco.Text = "Preço";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(197, 267);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(243, 20);
            this.textBoxMarca.TabIndex = 5;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(290, 245);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(51, 19);
            this.labelMarca.TabIndex = 35;
            this.labelMarca.Text = "Marca";
            // 
            // CadastroSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RainbowsCream_PI.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 515);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textboxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.textboxSabor);
            this.Controls.Add(this.labelSabor);
            this.Name = "CadastroSor";
            this.Text = "CadastroSor";
            this.Load += new System.EventHandler(this.CadastroSor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textboxQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textboxSabor;
        private System.Windows.Forms.Label labelSabor;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelMarca;
    }
}