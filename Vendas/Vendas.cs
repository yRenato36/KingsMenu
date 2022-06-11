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

namespace Vendas
{
    public partial class Vendas : Form
    {
        public void CarregarProdutos()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\CadastroProduto.txt";
            try
            {
                StreamReader sr = null;
                if (File.Exists(path))
                {
                    string line;
                    sr = new StreamReader(path);
                    line = sr.ReadLine();

                    string[] categoriaTemp;
                    gridPesquisa.Rows.Clear();

                    byte[] img;

                    while (line != null)
                    {

                        categoriaTemp = line.Split('|');
                        string pathImg = @"C:\Users\rs323\Desktop\PI 2º Semestre\Recusos do sistema\Imagem de produtos\" + categoriaTemp[0] + ".png";

                        MemoryStream ms = new MemoryStream();
                        img = null;

                        PictureBox imgPt = new PictureBox();
                        if (File.Exists(pathImg))
                        {
                            imgPt.Load(pathImg);
                            imgPt.Image.Save(ms, imgPt.Image.RawFormat);
                            img = ms.ToArray();
                        }

                        gridPesquisa.Rows.Add(img, categoriaTemp[1], categoriaTemp[2], categoriaTemp[4]);

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
        public Vendas()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {

        }
    }
}
