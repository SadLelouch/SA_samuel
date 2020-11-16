using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Samuel.Campos
{
    class Venda
    {
        public String cpf, n_vendedor;
        public double v_venda;
        public int cod_produto;


        public Venda(string cpf, int cod_produto, string n_vendedor, double v_venda)
        {
            this.cpf = cpf;
            this.cod_produto = cod_produto;
            this.n_vendedor = n_vendedor;
            this.v_venda = v_venda;
        }
        public Venda()
        {

        }
    }
}
