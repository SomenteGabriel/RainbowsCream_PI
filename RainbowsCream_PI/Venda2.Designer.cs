namespace RainbowsCream_PI
{
    partial class Venda2
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
            this.dataGridViewAdicionais = new System.Windows.Forms.DataGridView();
            this.labelSabor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAdicionais = new System.Windows.Forms.Label();
            this.labelRecipientes = new System.Windows.Forms.Label();
            this.dataGridViewRecipientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdicionais)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dataGridViewAdicionais
            // 
            this.dataGridViewAdicionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdicionais.Location = new System.Drawing.Point(71, 116);
            this.dataGridViewAdicionais.Name = "dataGridViewAdicionais";
            this.dataGridViewAdicionais.Size = new System.Drawing.Size(351, 349);
            this.dataGridViewAdicionais.TabIndex = 1;
            this.dataGridViewAdicionais.DoubleClick += new System.EventHandler(this.dataGridViewAdicionais_DoubleClick);
            // 
            // labelSabor
            // 
            this.labelSabor.AutoSize = true;
            this.labelSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSabor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSabor.Location = new System.Drawing.Point(210, 86);
            this.labelSabor.Name = "labelSabor";
            this.labelSabor.Size = new System.Drawing.Size(65, 24);
            this.labelSabor.TabIndex = 4;
            this.labelSabor.Text = "Sabor";
            this.labelSabor.Click += new System.EventHandler(this.labelSabor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelAdicionais);
            this.panel1.Controls.Add(this.labelRecipientes);
            this.panel1.Controls.Add(this.dataGridViewRecipientes);
            this.panel1.Controls.Add(this.labelSabor);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridViewAdicionais);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 515);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.textBoxPesquisa);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 46);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(23, 15);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(407, 20);
            this.textBoxPesquisa.TabIndex = 8;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::RainbowsCream_PI.Properties.Resources.procurar__1_;
            this.button1.Location = new System.Drawing.Point(450, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 34);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAdicionais
            // 
            this.labelAdicionais.AutoSize = true;
            this.labelAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdicionais.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAdicionais.Location = new System.Drawing.Point(191, 89);
            this.labelAdicionais.Name = "labelAdicionais";
            this.labelAdicionais.Size = new System.Drawing.Size(107, 24);
            this.labelAdicionais.TabIndex = 7;
            this.labelAdicionais.Text = "Adicionais";
            this.labelAdicionais.Click += new System.EventHandler(this.labelAdicionais_Click);
            // 
            // labelRecipientes
            // 
            this.labelRecipientes.AutoSize = true;
            this.labelRecipientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRecipientes.Location = new System.Drawing.Point(191, 89);
            this.labelRecipientes.Name = "labelRecipientes";
            this.labelRecipientes.Size = new System.Drawing.Size(120, 24);
            this.labelRecipientes.TabIndex = 6;
            this.labelRecipientes.Text = "Recipientes";
            this.labelRecipientes.Click += new System.EventHandler(this.labelRecipientes_Click);
            // 
            // dataGridViewRecipientes
            // 
            this.dataGridViewRecipientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipientes.Location = new System.Drawing.Point(71, 116);
            this.dataGridViewRecipientes.Name = "dataGridViewRecipientes";
            this.dataGridViewRecipientes.Size = new System.Drawing.Size(351, 349);
            this.dataGridViewRecipientes.TabIndex = 5;
            this.dataGridViewRecipientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipientes_CellContentClick);
            this.dataGridViewRecipientes.DoubleClick += new System.EventHandler(this.dataGridViewRecipientes_DoubleClick);
            // 
            // dataGridViewVenda
            // 
            this.dataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenda.Location = new System.Drawing.Point(604, 86);
            this.dataGridViewVenda.Name = "dataGridViewVenda";
            this.dataGridViewVenda.Size = new System.Drawing.Size(361, 258);
            this.dataGridViewVenda.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(485, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Finalizar venda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeletar.FlatAppearance.BorderSize = 0;
            this.buttonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Location = new System.Drawing.Point(604, 346);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(361, 35);
            this.buttonDeletar.TabIndex = 14;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(812, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Venda total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(928, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "R$";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.BackColor = System.Drawing.SystemColors.Control;
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelValor.Location = new System.Drawing.Point(959, 19);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(60, 24);
            this.labelValor.TabIndex = 16;
            this.labelValor.Text = "15,90";
            // 
            // buttonProximo
            // 
            this.buttonProximo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProximo.FlatAppearance.BorderSize = 0;
            this.buttonProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProximo.Location = new System.Drawing.Point(581, 418);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(404, 35);
            this.buttonProximo.TabIndex = 17;
            this.buttonProximo.Text = "Proximo";
            this.buttonProximo.UseVisualStyleBackColor = false;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // Venda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1035, 515);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewVenda);
            this.Controls.Add(this.panel1);
            this.Name = "Venda2";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdicionais)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewAdicionais;
        private System.Windows.Forms.Label labelSabor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelAdicionais;
        private System.Windows.Forms.Label labelRecipientes;
        private System.Windows.Forms.DataGridView dataGridViewRecipientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewVenda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Button buttonProximo;
    }
}