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
            this.label1 = new System.Windows.Forms.Label();
            this.boxPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.imgCarrinho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pesquisa";
            // 
            // boxPesquisa
            // 
            this.boxPesquisa.Location = new System.Drawing.Point(27, 59);
            this.boxPesquisa.Name = "boxPesquisa";
            this.boxPesquisa.Size = new System.Drawing.Size(234, 20);
            this.boxPesquisa.TabIndex = 22;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(267, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Location = new System.Drawing.Point(27, 88);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.Size = new System.Drawing.Size(315, 171);
            this.gridPesquisa.TabIndex = 25;
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.Location = new System.Drawing.Point(27, 266);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(116, 23);
            this.btnAddCarrinho.TabIndex = 26;
            this.btnAddCarrinho.Text = "Adicionar ao carrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = true;
            // 
            // imgCarrinho
            // 
            this.imgCarrinho.Image = global::Vendas.Properties.Resources.imgcarrinho;
            this.imgCarrinho.Location = new System.Drawing.Point(305, 16);
            this.imgCarrinho.Name = "imgCarrinho";
            this.imgCarrinho.Padding = new System.Windows.Forms.Padding(3);
            this.imgCarrinho.Size = new System.Drawing.Size(37, 37);
            this.imgCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCarrinho.TabIndex = 28;
            this.imgCarrinho.TabStop = false;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 311);
            this.Controls.Add(this.imgCarrinho);
            this.Controls.Add(this.btnAddCarrinho);
            this.Controls.Add(this.gridPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPesquisa);
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
    }
}

