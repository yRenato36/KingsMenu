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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
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
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // boxDesc
            // 
            this.boxDesc.Location = new System.Drawing.Point(170, 77);
            this.boxDesc.Name = "boxDesc";
            this.boxDesc.Size = new System.Drawing.Size(234, 20);
            this.boxDesc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque";
            // 
            // boxEstoque
            // 
            this.boxEstoque.Location = new System.Drawing.Point(170, 118);
            this.boxEstoque.Name = "boxEstoque";
            this.boxEstoque.Size = new System.Drawing.Size(234, 20);
            this.boxEstoque.TabIndex = 2;
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.White;
            this.imgBox.Location = new System.Drawing.Point(24, 20);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(140, 131);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 6;
            this.imgBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // boxValor
            // 
            this.boxValor.Location = new System.Drawing.Point(170, 158);
            this.boxValor.Name = "boxValor";
            this.boxValor.Size = new System.Drawing.Size(234, 20);
            this.boxValor.TabIndex = 3;
            // 
            // btnCarregarImg
            // 
            this.btnCarregarImg.Location = new System.Drawing.Point(24, 158);
            this.btnCarregarImg.Name = "btnCarregarImg";
            this.btnCarregarImg.Size = new System.Drawing.Size(140, 23);
            this.btnCarregarImg.TabIndex = 8;
            this.btnCarregarImg.Text = "Carregar imagem";
            this.btnCarregarImg.UseVisualStyleBackColor = true;
            this.btnCarregarImg.Click += new System.EventHandler(this.btnCarregarImg_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(24, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gridCategoria
            // 
            this.gridCategoria.AllowUserToAddRows = false;
            this.gridCategoria.AllowUserToDeleteRows = false;
            this.gridCategoria.BackgroundColor = System.Drawing.Color.White;
            this.gridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Descrição});
            this.gridCategoria.Location = new System.Drawing.Point(170, 196);
            this.gridCategoria.Name = "gridCategoria";
            this.gridCategoria.ReadOnly = true;
            this.gridCategoria.Size = new System.Drawing.Size(234, 90);
            this.gridCategoria.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(170, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // btnNovaCateg
            // 
            this.btnNovaCateg.Location = new System.Drawing.Point(170, 292);
            this.btnNovaCateg.Name = "btnNovaCateg";
            this.btnNovaCateg.Size = new System.Drawing.Size(100, 23);
            this.btnNovaCateg.TabIndex = 5;
            this.btnNovaCateg.Text = "Nova categoria";
            this.btnNovaCateg.UseVisualStyleBackColor = true;
            this.btnNovaCateg.Click += new System.EventHandler(this.btnNovaCateg_Click);
            // 
            // btnAlteCateg
            // 
            this.btnAlteCateg.Location = new System.Drawing.Point(304, 292);
            this.btnAlteCateg.Name = "btnAlteCateg";
            this.btnAlteCateg.Size = new System.Drawing.Size(100, 23);
            this.btnAlteCateg.TabIndex = 6;
            this.btnAlteCateg.Text = "Alterar categoria";
            this.btnAlteCateg.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(170, 321);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(103, 17);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "Produto Ativo";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroProdutos.Properties.Resources._066f195a5f87ea2b7f35a4cb1b11d7b3_desenho_geometrico_de_fundo_vermelho;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
    }
}

