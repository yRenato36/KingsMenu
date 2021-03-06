namespace Vendas
{
    partial class Vendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.label1 = new System.Windows.Forms.Label();
            this.boxPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.imgCarrinho = new System.Windows.Forms.PictureBox();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pesquisa";
            // 
            // boxPesquisa
            // 
            this.boxPesquisa.Location = new System.Drawing.Point(27, 59);
            this.boxPesquisa.Name = "boxPesquisa";
            this.boxPesquisa.Size = new System.Drawing.Size(234, 20);
            this.boxPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(267, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.AllowUserToAddRows = false;
            this.gridPesquisa.AllowUserToDeleteRows = false;
            this.gridPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Nome,
            this.Descrição,
            this.Valor});
            this.gridPesquisa.Location = new System.Drawing.Point(27, 88);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.Size = new System.Drawing.Size(315, 171);
            this.gridPesquisa.TabIndex = 2;
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.Location = new System.Drawing.Point(27, 266);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(116, 23);
            this.btnAddCarrinho.TabIndex = 3;
            this.btnAddCarrinho.Text = "Adicionar ao carrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = true;
            this.btnAddCarrinho.Click += new System.EventHandler(this.btnAddCarrinho_Click);
            // 
            // imgCarrinho
            // 
            this.imgCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.imgCarrinho.Image = global::Vendas.Properties.Resources.imgcarrinho;
            this.imgCarrinho.Location = new System.Drawing.Point(305, 16);
            this.imgCarrinho.Name = "imgCarrinho";
            this.imgCarrinho.Padding = new System.Windows.Forms.Padding(3);
            this.imgCarrinho.Size = new System.Drawing.Size(37, 37);
            this.imgCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCarrinho.TabIndex = 28;
            this.imgCarrinho.TabStop = false;
            // 
            // Imagem
            // 
            this.Imagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 20;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vendas.Properties.Resources._066f195a5f87ea2b7f35a4cb1b11d7b3_desenho_geometrico_de_fundo_vermelho;
            this.ClientSize = new System.Drawing.Size(370, 311);
            this.Controls.Add(this.imgCarrinho);
            this.Controls.Add(this.btnAddCarrinho);
            this.Controls.Add(this.gridPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPesquisa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.Button btnAddCarrinho;
        private System.Windows.Forms.PictureBox imgCarrinho;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

