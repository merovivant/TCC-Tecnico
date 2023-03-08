using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class Pedido : Conexao
    {
        public int idPedido { get;  set; }
        public string CPF { get; set; }
        public string DataPed { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public string primaryKey = "idPedido";
        public String NaoAvisarCadastro;

        public Pedido() { }
        public Pedido(string _CPF, string _DataPed, double _Total, string _Status)
        {
            this.CPF = _CPF.Trim();
            this.DataPed = _DataPed;
            this.Total = _Total;
            this.Status = _Status;
            CadastraObjeto(this);
        }
        public Pedido(string _CPF)
        {
            this.CPF = _CPF.Trim();
        }
        public Pedido(int _idPedido)
        {
            this.idPedido = _idPedido;
            ConsultaObjeto(this);
        }
    }
}
