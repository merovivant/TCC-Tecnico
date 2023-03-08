using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class ProdutoPedido : Conexao
    {
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public int Quantidade { get; set; }
        public String NaoAvisarCadastro;

        public ProdutoPedido()
        {

        }
        public ProdutoPedido(int _idPedido, string _idProduto, string _quantidade)
        {
            this.idPedido = _idPedido;
            this.idProduto = Convert.ToInt32(_idProduto);
            this.Quantidade = Convert.ToInt32(_quantidade);
            CadastraObjeto(this);
        }
    }
}
