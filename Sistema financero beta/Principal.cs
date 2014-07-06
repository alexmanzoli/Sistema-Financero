using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_financero_beta
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_cadCli_Click(object sender, EventArgs e)
        {
            //Quando clicar irar aparecer a tela de cadastro de empresa

            new FSIG1_CADEMP().Show();
        }
    }
}
