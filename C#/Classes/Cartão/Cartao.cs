using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel {
    class Cartao:Conexao
    {
        public string idCartao { get; set; }
        public double Saldo { get; set; }
        public string StatusCartao { get; set; }
        public string primaryKey = "idCartao";
        public String NaoAvisarUpdate;

        public Cartao(string _idCartao)
        {
            this.idCartao = _idCartao;
            ConsultaObjeto(this);
        }
    }
}
