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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BTN_acessar_Click(object sender, EventArgs e)
        {
            //Veriricar se o login e senha esta como esta abaixo

            if((textBox1.Text == "Alex") && (textBox2.Text == "123"))
            {
                //Se o login estiver correto ira abrir a tela

                this.Visible = false;
                MessageBox.Show("Seja bem vindo", "    Bem Vindo     ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Carregamento_2_Principal Carrega = new Carregamento_2_Principal();
                Carrega.Visible = true;
            }
                    else
                    {
                //Se estiver incorreto ira aparecer a mesagem de erro 

                 MessageBox.Show("Usuario ou Senha invalidos", "  ERRO   ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        private void BTN_sair_Click(object sender, EventArgs e)
        {
            //Se clicar em sair ira aparece a mensagem de confirmação

            if (MessageBox.Show("Você deseja sair do Sistema", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
            }
        }