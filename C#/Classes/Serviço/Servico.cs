using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosHotel
{
    class Servico : Conexao
    {
        public int idServico { get; set; }
        public int idHotel { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string primaryKey = "idServico";
        
        public Servico(int _idHotel, double _Preco, string _Descricao)
        {
            this.idHotel = _idHotel;
            this.Preco = _Preco;
            this.Descricao = _Descricao;
            this.Imagem = "assets/icons/" + _Descricao + ".png";
            this.Imagem = this.Imagem.Replace(" ", "-");
            CadastraObjeto(this);
        }
        public Servico(int _idServico, int _idHotel)
        {
            this.idServico = _idServico;
            this.idHotel = _idHotel;
            ConsultaObjeto(this);
        }
        public Servico(string _idServico)
        {
            this.idServico = Convert.ToInt32(_idServico);
            ConsultaObjeto(this);
        }
    }
}
