using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class Evento : Conexao
    {
        public int idEvento { get; set; }
        public int idHotel { get; set; }
        public string Nome { get; set; }
        public string DataEvento { get; set; }
        public string Localizacao { get; set; }
        public string Publico { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string primaryKey = "idEvento";
        
        public Evento() { }

        public Evento(int _idhotel)
        {
            this.idHotel = _idhotel;
        }

        public Evento(int _idhotel, string _nome, DateTime _dataevento, string _localizacao, string _publico, double _preco, string _descricao)
        {
            this.idHotel = _idhotel;
            this.Nome = _nome;
            this.DataEvento = _dataevento.ToString("yyyy-MM-dd HH:mm:ss");
            this.Localizacao = _localizacao;
            this.Publico = _publico;
            this.Preco = _preco;
            this.Descricao = _descricao;
            CadastraObjeto(this);
        }
    }
}
