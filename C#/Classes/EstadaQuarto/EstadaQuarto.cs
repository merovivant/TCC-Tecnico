using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class EstadaQuarto : Conexao
    {
        public int idEstada { get; set; }
        public int idQuarto { get; set; }
        public string primaryKey = "idEstada";
        public String NaoAvisarCadastro;
        public String NaoAvisarUpdate;

        public EstadaQuarto() { }
        public EstadaQuarto(int _idEstada, int _idQuarto)
        {
            this.idEstada = _idEstada;
            this.idQuarto = _idQuarto;
            CadastraObjeto(this);
        }
    }
}
