using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_inicio
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CadastroProdutos.CadastroProdutos form = new CadastroProdutos.CadastroProdutos();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CadastroProdutos.CadastroProdutos form = new CadastroProdutos.CadastroProdutos();
            this.Hide();
            form.ShowDialog();
            this.Show();

        }
    }
}
