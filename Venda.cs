using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanchonete
{
    class Venda//indica o nome da classe
    {
        //atributos da classe Venda
        public int qtdLanche;
        public int qtdRefri;
        public double totalConta;
        public double dinheiroRecebido;
        public double troco;

        //método para calcular o Total a pagar
        public void calculaTotalPagar()
        {//this significa que estamos falando desta classe
            this.totalConta = this.qtdLanche * 6 + this.qtdRefri * 2;
        }

        //método para calcular o troco
        public void calculaTroco()
        {
            this.troco = this.dinheiroRecebido - this.totalConta;
        }

    }
}
