using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.IO;
using System.Globalization;

namespace Cadastrar
{
    public partial class CadastroCliente : Form
    {
        //validação de email
        public bool ValidaEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        //validação de cpf com os cálculos necessários
        public bool ValidaCPF(string vrCPF)
        {
            bool igual = true;
            int[] numeros = new int[11];
            int soma = 0, resultado;
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;

            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }
        //validação de cep
        public bool ValidaCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            }
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
        public bool ValidaSenhas(string senha, string senhaConf)
        {
            return (boxSenha.Text == boxConfSenha.Text);
        }
        public bool ValidaCamposNotNull(string campo)
        {
            return campo.Length > 0;
        }

        //função contrutura, carrega as informações de um arquivo
        public CadastroCliente()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("C:\\Users\\rs323\\Desktop\\CadastroClientes.txt");
            string line = sr.ReadLine();

            string[] dados = line.Split('|');
            boxName.Text = dados[0];
            boxCPF.Text = dados[1];
            boxTel.Text = dados[2];
            boxData.Value = DateTime.ParseExact(dados[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            boxEmail.Text = dados[4];
            boxSenha.Text = dados[5];
            boxConfSenha.Text = dados[6];
            boxRua.Text = dados[7];
            boxCEP.Text = dados[8];
            boxEstado.Text = dados[9];
            boxCidade.Text = dados[10];
            boxNum.Text = dados[11];
            boxBairro.Text = dados[12];
            boxComple.Text = dados[13];
            sr.Close();
        }
        //função criadora, cria uma arquivo .txt com os dados cadastrados
        public void SalvarCadastro()
        {
            string path = @"C:\\Users\\rs323\\Desktop\\CadastroClientes.txt";

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
                sw.WriteLine(boxName.Text + "|" +
                    boxCPF.Text + "|" +
                    boxTel.Text + "|" +
                    boxData.Text + "|" +
                    boxEmail.Text + "|" +
                    boxSenha.Text + "|" +
                    boxConfSenha.Text + "|" +
                    boxRua.Text + "|" +
                    boxCEP.Text + "|" +
                    boxEstado.Text + "|" +
                    boxCidade.Text + "|" +
                    boxNum.Text + "|" +
                    boxBairro.Text + "|" +
                    boxComple.Text);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        //validação dos campos que estiverem vazios
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidaSenhas(boxSenha.Text, boxConfSenha.Text))
            {
                MessageBox.Show("As senhas precisam ser iguais");
                return;
            }
            if (!ValidaCamposNotNull(boxName.Text))
            {
                MessageBox.Show("Preencha o campo Nome");
                return;
            }
            if (!ValidaCamposNotNull(boxCPF.Text))
            {
                MessageBox.Show("Preencha o campo CPF");
                return;
            }
            if (!ValidaCamposNotNull(boxTel.Text))
            {
                MessageBox.Show("Preencha o campo Telefone");
                return;
            }
            if (!ValidaCamposNotNull(boxEmail.Text))
            {
                MessageBox.Show("Preencha o campo Email");
                return;
            }
            if (!ValidaCamposNotNull(boxSenha.Text))
            {
                MessageBox.Show("Preencha o campo Senha");
                return;
            }
            if (!ValidaCamposNotNull(boxConfSenha.Text))
            {
                MessageBox.Show("Preencha o campo Confirmar Senha");
                return;
            }
            if (!ValidaCamposNotNull(boxRua.Text))
            {
                MessageBox.Show("Preencha o campo Rua");
                return;
            }
            if (!ValidaCamposNotNull(boxCEP.Text))
            {
                MessageBox.Show("Preencha o campo CEP");
                return;
            }
            if (!ValidaCamposNotNull(boxEstado.Text))
            {
                MessageBox.Show("Preencha o campo Estado");
                return;
            }
            if (!ValidaCamposNotNull(boxCidade.Text))
            {
                MessageBox.Show("Preencha o campo Cidade");
                return;
            }
            if (!ValidaCamposNotNull(boxNum.Text))
            {
                MessageBox.Show("Preencha o campo Número");
                return;
            }
            if (!ValidaCamposNotNull(boxBairro.Text))
            {
                MessageBox.Show("Preencha o campo Bairro");
                return;
            }

            SalvarCadastro();
            MessageBox.Show("Cadastro realizado com sucesso!");

            this.Close();
        }
        //chama a função dos cálculos do CPF
        private void boxCPF_Validated(object sender, EventArgs e)
        {
            MaskedTextBox _sender = (MaskedTextBox)sender;

            if (_sender.Text.Length > 0 && !ValidaCPF(_sender.Text))
            {
                MessageBox.Show("CPF Inválido!");
                return;
            }
        }
        //chama a função das necessidades do email
        private void boxEmail_Validated(object sender, EventArgs e)
        {
            TextBox _sender = (TextBox)sender;

            if (_sender.Text.Length > 0 && !ValidaEmail(_sender.Text))
            {
                MessageBox.Show("Email Inválido!");
                return;
            }
        }
        //chama a função que valida o CEP
        private void boxCEP_Validated(object sender, EventArgs e)
        {
            MaskedTextBox _sender = (MaskedTextBox)sender;

            if (_sender.Text.Length > 0 && !ValidaCep(_sender.Text))
            {
                MessageBox.Show("CEP Inválido!");
                return;
            }
        }
    }
}
