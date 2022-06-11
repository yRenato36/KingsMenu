using Cadastrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool CarregarClientes(string login, string senha)
        {
            string path = @"C:\\Users\\rs323\\Desktop\\CadastroClientes.txt";
            try
            {
                StreamReader sr = null;
                if (File.Exists(path))
                {
                    string line;
                    sr = new StreamReader(path);
                    line = sr.ReadLine();

                    string[] categoriaTemp;

                    while (line != null)
                    {
                        categoriaTemp = line.Split('|');
                        if (categoriaTemp[0].Equals(login))
                        {
                            return categoriaTemp[5].Equals(senha);
                        }
                        //Read the next line
                        line = sr.ReadLine();
                    }
                    //close the file
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro inesperado\n" + ex.Message);
            }
            return false;
        }

        public bool ValidarLoginAdmin()
        {
            return (boxUsuario.Text.Equals("admin") && boxSenha.Text.Equals("admin"));
        }

        public bool ValidarLogin()
        {
            return CarregarClientes(boxUsuario.Text, boxSenha.Text);
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente form = new CadastroCliente();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarLoginAdmin())
            {
                ListaPedidos.ListaPedidos form = new ListaPedidos.ListaPedidos();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else if (ValidarLogin())
            {
                Vendas.Vendas form = new Vendas.Vendas();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }
    }
}
