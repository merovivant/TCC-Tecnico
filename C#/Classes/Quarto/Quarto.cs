using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    class Quarto : Conexao
    {
        public int idQuarto { get; set; }
        public int Número { get; set; }
        public int idHotel { get; set; }
        public int Capacidade { get; set; }
        public double Preco { get; set; }
        public string Status;
        public string Imagem { get; set; }
        public string primaryKey = "idQuarto";

        public Quarto() { }

        public Quarto(int _idQuarto)
        {
            this.idQuarto = _idQuarto;
            ConsultaObjeto(this);
        }

        public Quarto(int _idQuarto, int _idHotel)
        {
            this.idQuarto = _idQuarto;
            this.idHotel = _idHotel;
        }

        public Quarto(int _idhotel, int _capacidade, int _numero , double _preco)
        {
            this.idHotel = _idhotel;
            this.Capacidade = _capacidade;
            this.Número = _numero;
            this.Preco = _preco;
        }
    }
}

