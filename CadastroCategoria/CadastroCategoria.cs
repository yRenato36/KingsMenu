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

namespace CadastroCategoria
{
    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        public bool ValidaCamposNotNull(string campo)
        {
            return campo.Length > 0;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposNotNull(boxNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome");
                return;
            }
            if (!ValidaCamposNotNull(boxDesc.Text))
            {
                MessageBox.Show("Preencha o campo Descrição");
                return;
            }
            SalvarCategoria();
            MessageBox.Show("Categoria cadastrada com sucesso!");
        }
        public void SalvarCategoria()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\Categorias.txt";

            try
            {
                StreamWriter sw = null;
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                }
                else
                {
                    sw = File.AppendText(path);
                }
                sw.WriteLine(boxNome.Text + "|" + boxDesc.Text);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }
    }
}
