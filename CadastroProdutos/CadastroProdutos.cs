using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CadastroProdutos
{
    public partial class CadastroProdutos : Form
    {
        public void CarregarCategorias()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\Categorias.txt";
            try
            {
                StreamReader sr = null;
                if (File.Exists(path))
                {
                    string line;
                    sr = new StreamReader(path);
                    line = sr.ReadLine();

                    string[] categoriaTemp;
                    gridCategoria.Rows.Clear();

                    while (line != null)
                    {
                        categoriaTemp = line.Split('|');
                        gridCategoria.Rows.Add(categoriaTemp[0], categoriaTemp[1]);
                        
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
        }
        public CadastroProdutos()
        {
            InitializeComponent();
            CarregarCategorias();
        }
        public bool ValidaCamposNotNull(string campo)
        {
            return campo.Length > 0;
        }
        public int CarregarUltimoId()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\CadastroProduto.txt";
            try
            {
                StreamReader sr = null;
                if (File.Exists(path))
                {
                    string line;
                    int index = 1;
                    sr = new StreamReader(path);
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        //Read the next line
                        line = sr.ReadLine();
                        index++;
                    }
                    //close the file
                    sr.Close();
                    return index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro inesperado\n" + ex.Message);
            }
            return 1;
        }

        public void SalvarProdutos(int index)
        {
            string path = @"C:\\Users\\rs323\\Desktop\\CadastroProduto.txt";

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
                sw.WriteLine(index + "|" + boxNome.Text + "|" +
                    boxDesc.Text + "|" +
                    boxEstoque.Text + "|" +
                    "R$" + boxValor.Text + "|");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void SalvarImagemProduto(int index)
        {
            string path = @"C:\\Users\\rs323\\Desktop\\PI 2º Semestre\\Recusos do sistema\\Imagem de produtos\\" + index + ".png";

            if (imgBox.ImageLocation != "")
            {
                imgBox.Image.Save(path, ImageFormat.Png);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposNotNull(boxNome.Text))
            {
                MessageBox.Show("O campo Nome está vazio");
                //para o processo do if
                return;
            }
            if (!ValidaCamposNotNull(boxDesc.Text))
            {
                MessageBox.Show("O campo Descrição está vazio");
                return;
            }
            if (!ValidaCamposNotNull(boxEstoque.Text))
            {
                MessageBox.Show("O campo Estoque está vazio");
                return;
            }
            if (!ValidaCamposNotNull(boxValor.Text))
            {
                MessageBox.Show("O campo Valor está vazio");
                return;
            }
            int index = CarregarUltimoId();
            SalvarProdutos(index);
            SalvarImagemProduto(index);
            MessageBox.Show("Cadastro realizado com sucesso!");

        }

        private void btnCarregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgBox.ImageLocation = file.FileName;
            }
        }

        private void btnNovaCateg_Click(object sender, EventArgs e)
        {
            CadastroCategoria.CadastroCategoria form = new CadastroCategoria.CadastroCategoria();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
