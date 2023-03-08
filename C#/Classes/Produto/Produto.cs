using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    class Produto: Conexao
    {
        ProdutoDAL sql = new ProdutoDAL();
        public int idProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public int idHotel { get; set; }
        public string Imagem { get; set; }
        public string primaryKey = "idProduto";

        public Produto(int _idhotel, string _descricao, double _preco, int _quantidade)
        {
            this.idHotel = _idhotel;
            this.Preco =  _preco;
            this.Descricao = _descricao;
            this.Quantidade  = _quantidade;
            this.Imagem = "assets/imagens/" + _descricao + ".png";
            CadastraObjeto(this);
        }
        public Produto(int _idProduto, int _idHotel)
        {
            this.idProduto = _idProduto;
            this.idHotel = _idHotel;
            ConsultaObjeto(this);
        }
        public Produto(string _idProduto)
        {
            this.idProduto = Convert.ToInt32(_idProduto);
            ConsultaObjeto(this);
        }
    }
}
