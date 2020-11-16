using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Samuel.Campos
{
    class Produto
    {
        public string n_produto, cod_produto;
        public Produto (string n_produto, string cod_produto)
        {
            this.cod_produto = cod_produto;
            this.n_produto = n_produto;
        }
    }
}
