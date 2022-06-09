using Cadastrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente form = new CadastroCliente();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
