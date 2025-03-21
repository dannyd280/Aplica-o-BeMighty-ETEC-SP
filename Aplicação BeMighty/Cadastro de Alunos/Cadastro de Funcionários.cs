using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;


namespace Cadastro_de_Alunos
{
    public partial class Cadastro_de_Funcionários : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1VUTL33;Initial Catalog=BeMighty;Integrated Security=True");/*copiando do appconfig*/
       // SqlCommand comando = new SqlCommand();/*instanciando*/
        //SqlDataReader dr;/*leitor*/
        //void carregaLista()
        //{


           /* conn.Open();
            comando.CommandText = "select * from tbl_Funcionario";




            conn.Close();
        }
        /*declarei arq tipo img*/
        //Image Arquivo;

        public Cadastro_de_Funcionários()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
			string validar = mskCpf.Text;
			mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
				return;
            }

            if (cbxSexo.Text == "")
            {
                MessageBox.Show("Informe o Sexo", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxSexo.Focus();
                return;
            }

            if (mskCpf.Text == "")
            {
                MessageBox.Show("Informe o CPF", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskCpf.Focus();
				return;
            }
			else
			{
				mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
				
			}
			if (CPF.ValidaCPF(validar))
			{
				//enviar dados para o banco
			}
			else
			{
				MessageBox.Show("CPF Inválido", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				mskCpf.Clear();
				mskCpf.Focus();
				return;
			}

            if(txtRG.Text == "")
            {
                MessageBox.Show("Informe o RG", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRG.Focus();
                return;
            }
            if (ValidarRG(txtRG.Text))
            {

            }
            else
            {
                MessageBox.Show("RG Inválido", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRG.Clear();
                txtRG.Focus();
                return;
            }
           
             if (txtCEP.Text == "")
            {
                MessageBox.Show("Informe o CEP !", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCEP.Focus();
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Informe o Logradouro", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogradouro.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Informe o Número", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
            }
            else if (cbxUF.Text == "")
            {
                MessageBox.Show("Informe a UF", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxUF.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Informe a Cidade", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
            }
            else if (txtDDD1.Text == "")
            {
                MessageBox.Show("Informe o DDD", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDDD1.Focus();
            }
             else if(txtTelefone.Text == "")
            {
                MessageBox.Show("Informe o Telefone", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone.Focus();
            }
            //
            if (txtNome.Text != "" && cbxSexo.Text != "" && mskCpf.Text != "" && txtRG.Text != "" && mskDataNascimento.Text != "" && txtCEP.Text != "" && txtLogradouro.Text != ""
              && txtNumero.Text != "" && cbxUF.Text != "" && txtComplemento.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtDDD1.Text != "" && txtTelefone.Text != "" && txtDDD2.Text != "" && txtTelefone2.Text != "" && txtEmail.Text != "")
            {
                string teste = mskCpf.Text;

                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação
                string cpf1 = mskCpf.Text;

              //  conn.Open();/*abrindo base de dados*/
               // comando.CommandText = "insert into tbl_Funcionario(nomeFuncionario,Sexo,Logradouro,numEndereco,UF,Cidade,Telefone,RG,CEP,Bairro,Email,Complemento,CPF,DDD1,DDD2,Celular) values ('" + txtNome.Text + "','" + cbxSexo.Text + "','" + txtLogradouro.Text + "','" + txtNumero.Text + "','" + cbxUF.Text + "','" + txtCidade.Text + "','" + txtTelefone.Text + "','" + txtRG.Text + "','" + txtCEP.Text + "','" + txtBairro.Text + "','" + txtEmail.Text + "','" + txtComplemento.Text + "','" + cpf1 + "','" + txtDDD1.Text + "','" + txtDDD2.Text + "','" + txtTelefone2.Text + "')";
                //comando.ExecuteNonQuery();/*executando bd*/
                //conn.Close();/*fechar bd*/
                //carregaLista();
                //txtNome.Clear();
                cbxSexo.ResetText();
                txtLogradouro.Clear();
                txtNumero.Clear();
                cbxUF.ResetText();
                txtCidade.Clear();
                txtTelefone.Clear();
                txtComplemento.Clear();
                txtRG.Clear();
                mskCpf.Clear();
                txtCEP.Clear();
                txtBairro.Clear();
                txtEmail.Clear();
                MessageBox.Show("Dados Cadastrados !", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
        }
       

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void mskCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void txtDDD1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar)) e.Handled = true;
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
                       txtNome.Clear();
                       mskCpf.Clear();
                       cbxSexo.ResetText();
                       txtRG.Clear();
                       txtCEP.Clear();
                       txtLogradouro.Clear();
                       txtNumero.Clear();
                       txtBairro.Clear();
                       txtComplemento.Clear();
                       cbxUF.ResetText();           
                       txtEmail.Clear();                                   
                       txtCidade.Clear();                       
                       txtNome.Focus();
                       pbFotoFunc.Image = null;

        }

        private void btnSelecFoto_Click(object sender, EventArgs e)
        {
            //Image Arquivo;
            OpenFileDialog img = new OpenFileDialog();

            img.InitialDirectory = "c:\\";/*qual diretório ?*/
            img.Filter = "JPG(*.JPG)|*.jpg";/*tipo de arquivo ?*/
            if (img.ShowDialog() == DialogResult.OK)
            {
               // Arquivo = Image.FromFile(img.FileName);
               // pbFotoFunc.Image = Arquivo;
            }
        }
        bool ValidarRG(string RG)
        {
            try
            {
                RG = txtRG.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
                int n1 = int.Parse(RG.Substring(0, 1));
                int n2 = int.Parse(RG.Substring(1, 1));
                int n3 = int.Parse(RG.Substring(2, 1));
                int n4 = int.Parse(RG.Substring(3, 1));
                int n5 = int.Parse(RG.Substring(4, 1));
                int n6 = int.Parse(RG.Substring(5, 1));
                int n7 = int.Parse(RG.Substring(6, 1));
                int n8 = int.Parse(RG.Substring(7, 1));

                string DV = RG.Substring(8, 1);

                int Soma = n1 * 2 + n2 * 3 + n3 * 4 + n4 * 5 + n5 * 6 + n6 * 7 + n7 * 8 + n8 * 9;
                string digitoVerificador = Convert.ToString(Soma % 11);

                if (digitoVerificador == "1")
                {
                    digitoVerificador = "x";
                }
                else if (digitoVerificador == "0")
                {
                    digitoVerificador = "0";
                }
                else
                {
                    digitoVerificador = (11 - int.Parse(digitoVerificador)).ToString();
                }

                if (digitoVerificador == DV)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch
            {
                return false;
            }
        }

        private void pbFotoFunc_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_Funcionários_Load(object sender, EventArgs e)
        {
            //comando.Connection = conn;/*abertura de BD*//*usar try catch p/solucao de erro conect bd*/
            //carregaLista();
        }
    }
}
