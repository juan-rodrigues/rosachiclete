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

namespace EmpresaTextil
{
    public partial class FormFornecedores : Form
    {
        string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Downloads\EmpresaTextil\Fornecedores\Fornecedores.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dtFornecedores = new DataTable();

        private void updateFornecedores()
        {
            string SQL = @"SELECT * FROM fornecedores";
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand(SQL, con);
            dtFornecedores.Clear();
            con.Open();
            dtFornecedores.Load(cmd.ExecuteReader());
            con.Close();
        }

        private void limpar()
        {
            tbCNPJ.Clear();
            tbEmail.Clear();
            tbNome.Clear();
            tbTelefone.Clear();
        }

        public FormFornecedores()
        {
            InitializeComponent();
            updateFornecedores();
        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            string SQL = @"INSERT INTO fornecedores(CNPJ, NOME, TELEFONE, EMAIL)
                           VALUES(@CNPJ, @NOME, @TELEFONE, @EMAIL)";
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand(SQL, con);

            tbCNPJ.Text.Replace(",", "");
            tbCNPJ.Text.Replace("/", "");
            tbCNPJ.Text.Replace("-", "");
            tbTelefone.Text.Replace("(", "");
            tbTelefone.Text.Replace(")", "");
            tbTelefone.Text.Replace("-", "");

            cmd.Parameters.AddWithValue("@CNPJ", tbCNPJ.Text);
            cmd.Parameters.AddWithValue("@NOME", tbNome.Text);
            cmd.Parameters.AddWithValue("@TELEFONE", tbTelefone.Text);
            cmd.Parameters.AddWithValue("@EMAIL", tbEmail.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            updateFornecedores();
            limpar();
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            FormBuscaFornecedores bf = new FormBuscaFornecedores();
            bf.Show();
        }

        private void BtDeletar_Click(object sender, EventArgs e)
        {
            string SQL = @"DELETE FROM fornecedores";
            SqlConnection con = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand(SQL, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            updateFornecedores();
        }
    }
}
