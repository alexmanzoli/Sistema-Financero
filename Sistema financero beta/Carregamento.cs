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
    public partial class Carregamento : Form
    {
        public Carregamento()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //Carregamento de tela

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
                    else
                  {
                //Abrir tela de login se fazer o carregamento completo
                    this.Visible = false;
                        TelaLogin Login = new TelaLogin();
                        Login.Visible = true;
                        timer1.Stop();
                    }
                }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
            }
        }
