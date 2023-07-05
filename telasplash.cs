using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class telasplash : Form
    {
        public telasplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {//vai aparecendo o progressBar1 conforme preencher o componente da tela
                barra.Value = barra.Value + 2;
            }
            else//se a barra já completou 100%
            {
                timer1.Enabled = false;//desativar o timer
                this.Hide();//fecha a tela ativa
                Form1 abre = new Form1();//tela de lanchonete
                abre.ShowDialog();//abre a tela do lanchonete
            }
        }
    }
}
