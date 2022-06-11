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

namespace CupomDesconto
{
    public partial class CupomDesconto : Form
    {
        public CupomDesconto()
        {
            InitializeComponent();
        }
        public bool ValidaCamposNotNull(string campo)
        {
            return campo.Length > 0;
        }
        public void SalvarCupom()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\Cupom.txt";

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
                sw.WriteLine(boxValor.Text + "|" + dataValidade.Text);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposNotNull(boxValor.Text))
            {
                MessageBox.Show("Preencha o campo Valor");
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
