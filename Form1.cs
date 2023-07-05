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
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }
        //nesta linha eu digo para a memória ram que estou usando a classe Venda
        Venda lanchonete = new Venda();//instancia da classe

        private void button1_Click_1(object sender, EventArgs e)
        {//botão calcular conta
            lanchonete.qtdLanche = int.Parse(txtLanche.Text);
            lanchonete.qtdRefri = int.Parse(txtRefri.Text);

            lanchonete.calculaTotalPagar();//chamada do método
            //mostra o valor total da conta na caixa de texto do form
            txtTotalConta.Text = Convert.ToString(lanchonete.totalConta);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //botão calcular Troco
            lanchonete.dinheiroRecebido = Convert.ToDouble(txtDinheiro.Text);

            lanchonete.calculaTroco();//chamada do método

            txtTroco.Text = Convert.ToString(lanchonete.troco);
        }

        private void button3_Click(object sender, EventArgs e)
        {//botão limpar 
            txtLanche.Text = "";
            txtRefri.Text = "";
            txtTotalConta.Text = "";
            txtDinheiro.Text = "";
            txtTroco.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTotalConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
