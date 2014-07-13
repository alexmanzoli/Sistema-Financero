using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Sistema_financero_beta
{
    public partial class FSIG1_CADEMP : Form
    {
    
        public FSIG1_CADEMP()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexao = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\Term01\Documents\GitHub\Sistema-Financero\Sistema financero beta\SISTEMA.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            SqlConnection con = new SqlConnection (conexao);
            SqlCommand cmd = new SqlCommand ("insert into CAD_EMP(CSI_ID, CSI_NOME, CSI_NOME_FAM, CSI_END, CSI_NUM, CSI_COMPL, CSI_BAIRRO, CSI_UF, CSI_CIDADE, CSI_TEL, CSI_FAX, CSI_CNPJ, CSI_INCRI_ES, CSI_INCRI_MU, CSI_EMAIL, CSI_ARQUIVAMENTO, CSI_CO_ATIVI) Values ('" +textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"', '"+textBox4.Text+"', '"+textBox5.Text+"', '"+textBox6.Text+"', '"+textBox7.Text+"', '"+textBox8.Text+"', '"+textBox9.Text+"', '"+textBox10.Text+"', '"+textBox11.Text+"', '"+textBox12.Text+"', '"+textBox13.Text+"', '"+textBox14.Text+"', '"+textBox15.Text+"', '"+textBox16.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
  
        }
    }
}
