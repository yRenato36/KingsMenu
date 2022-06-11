using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_inicio;

namespace ListaPedidos
{
    public partial class ListaPedidos : Form
    {
        public ListaPedidos()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnCupom_Click(object sender, EventArgs e)
        {
            CupomDesconto.CupomDesconto form = new CupomDesconto.CupomDesconto();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
