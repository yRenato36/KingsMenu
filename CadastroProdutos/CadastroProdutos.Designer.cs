namespace CadastroProdutos
{
    partial class CadastroProdutos
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
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxEstoque = new System.Windows.Forms.TextBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxValor = new System.Windows.Forms.TextBox();
            this.btnCarregarImg = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gridCategoria = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovaCateg = new System.Windows.Forms.Button();
            this.btnAlteCateg = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(170, 38);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(234, 20);
            this.boxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // boxDesc
            // 
            this.boxDesc.Location = new System.Drawing.Point(170, 77);
            this.boxDesc.Name = "boxDesc";
            this.boxDesc.Size = new System.Drawing.Size(234, 20);
            this.boxDesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque";
            // 
            // boxEstoque
            // 
            this.boxEstoque.Location = new System.Drawing.Point(170, 118);
            this.boxEstoque.Name = "boxEstoque";
            this.boxEstoque.Size = new System.Drawing.Size(234, 20);
            this.boxEstoque.TabIndex = 4;
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(24, 20);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(140, 131);
            this.imgBox.TabIndex = 6;
            this.imgBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(170, 158);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(234, 20);
            this.boxValor.TabIndex = 7;
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.Location = new System.Drawing.Point(24, 158);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(140, 23);
            this.btnCarregarImg.TabIndex = 9;
            this.btnCarregarImg.Text = "Carregar imagem";
            this.btnCarregarImg.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gridCategoria
            // 
            this.gridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoria.Location = new System.Drawing.Point(170, 196);
            this.gridCategoria.Name = "gridCategoria";
            this.gridCategoria.Size = new System.Drawing.Size(234, 90);
            this.gridCategoria.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // btnNovaCateg
            // 
            this.btnNovaCateg.Location = new System.Drawing.Point(170, 292);
            this.btnNovaCateg.Name = "btnNovaCateg";
            this.btnNovaCateg.Size = new System.Drawing.Size(100, 23);
            this.btnNovaCateg.TabIndex = 14;
            this.btnNovaCateg.Text = "Nova categoria";
            this.btnNovaCateg.UseVisualStyleBackColor = true;
            // 
            // btnAlteCateg
            // 
            this.btnAlteCateg.Location = new System.Drawing.Point(304, 292);
            this.btnAlteCateg.Name = "btnAlteCateg";
            this.btnAlteCateg.Size = new System.Drawing.Size(100, 23);
            this.btnAlteCateg.TabIndex = 15;
            this.btnAlteCateg.Text = "Alterar categoria";
            this.btnAlteCateg.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(170, 321);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(90, 17);
            this.checkBox.TabIndex = 16;
            this.checkBox.Text = "Produto Ativo";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 372);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.btnAlteCateg);
            this.Controls.Add(this.btnNovaCateg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregarImg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxValor);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNome);
            this.Name = "CadastroProdutos";
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxEstoque;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxValor;
        private System.Windows.Forms.Button btnCarregarImg;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView gridCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovaCateg;
        private System.Windows.Forms.Button btnAlteCateg;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

