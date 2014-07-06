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
    public partial class Carregamento_2_Principal : Form
    {
        public Carregamento_2_Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Verificar se o carregamento foi concluido

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
                    else
                  {
                //Abrir tela principal

                    this.Visible = false;
                        Principal FRM = new Principal();
                        FRM.Visible = true;
                        timer1.Stop();
                    }
                }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        }
    }
