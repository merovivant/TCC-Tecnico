using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class ServicoPedido: Conexao
    {
        public int idPedido { get; set; }
        public int idServico { get;  set; }
        public String NaoAvisarCadastro;

        public ServicoPedido()
        {

        }
        public ServicoPedido(int _idPedido, string _idServico)
        {
            this.idPedido = _idPedido;
            this.idServico = Convert.ToInt32(_idServico);
            CadastraObjeto(this);
        }
    }
}
