using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class Estada: Conexao
    {

        public int idEstada { get;  set;  }
        public int idHotel { get; set; }
        public string CPF { get;  set; }
        public string DataCheckin { get; set; }
        public string DataCheckout { get; set; }
        public double Preco { get; set; }
        public string Pagamento { get; set; }
        public string primaryKey = "idEstada";
        public String NaoAvisarCadastro;

        public Estada() { }
        public Estada(string _CPF)
        {
            this.CPF = _CPF;
        }
        public Estada(int _idEstada)
        {
            this.idEstada = _idEstada;
            ConsultaObjeto(this);
        }
    }
}
