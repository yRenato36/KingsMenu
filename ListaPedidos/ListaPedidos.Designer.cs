namespace ListaPedidos
{
    partial class ListaPedidos
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(192, 180);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 23);
            this.btnFinalizar.TabIndex = 28;
            this.btnFinalizar.Text = "Finalizar pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // gridPedidos
            // 
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Location = new System.Drawing.Point(35, 56);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.Size = new System.Drawing.Size(454, 118);
            this.gridPedidos.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pedidos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(35, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 238);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.label1);
            this.Name = "ListaPedidos";
            this.Text = "Lista de pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}

