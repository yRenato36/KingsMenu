namespace WindowsFormsApp2
{
    partial class Carrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            this.label1 = new System.Windows.Forms.Label();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.btnFInalizarPed = new System.Windows.Forms.Button();
            this.btnRemoverProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCupom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // gridPedidos
            // 
            this.gridPedidos.BackgroundColor = System.Drawing.Color.White;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Location = new System.Drawing.Point(39, 42);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.Size = new System.Drawing.Size(454, 118);
            this.gridPedidos.TabIndex = 0;
            // 
            // btnFInalizarPed
            // 
            this.btnFInalizarPed.Location = new System.Drawing.Point(279, 213);
            this.btnFInalizarPed.Name = "btnFInalizarPed";
            this.btnFInalizarPed.Size = new System.Drawing.Size(153, 23);
            this.btnFInalizarPed.TabIndex = 3;
            this.btnFInalizarPed.Text = "Finalizar pedido";
            this.btnFInalizarPed.UseVisualStyleBackColor = true;
            this.btnFInalizarPed.Click += new System.EventHandler(this.btnFInalizarPed_Click);
            // 
            // btnRemoverProd
            // 
            this.btnRemoverProd.Location = new System.Drawing.Point(39, 166);
            this.btnRemoverProd.Name = "btnRemoverProd";
            this.btnRemoverProd.Size = new System.Drawing.Size(153, 23);
            this.btnRemoverProd.TabIndex = 1;
            this.btnRemoverProd.Text = "Remover produto";
            this.btnRemoverProd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cupom de Desconto";
            // 
            // boxCupom
            // 
            this.boxCupom.Location = new System.Drawing.Point(39, 215);
            this.boxCupom.Name = "boxCupom";
            this.boxCupom.Size = new System.Drawing.Size(234, 20);
            this.boxCupom.TabIndex = 2;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._066f195a5f87ea2b7f35a4cb1b11d7b3_desenho_geometrico_de_fundo_vermelho;
            this.ClientSize = new System.Drawing.Size(533, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxCupom);
            this.Controls.Add(this.btnRemoverProd);
            this.Controls.Add(this.btnFInalizarPed);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.Button btnFInalizarPed;
        private System.Windows.Forms.Button btnRemoverProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCupom;
    }
}

