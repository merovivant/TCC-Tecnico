using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CosmosHotel
{
    class ProdutoDAL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public ProdutoDAL()
        {
        }

        public DataTable Consulta(string _busca, int _idHotel)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select idProduto, Descricao, Preco, Quantidade from tblProduto where (idProduto = '{_busca}' or Descricao like '%{_busca}%') and idHotel = '{_idHotel}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }

        public DataTable ListarGrid(int _idHotel)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select idProduto, Descricao, Preco, Quantidade from tblProduto where idHotel = '{_idHotel}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }
    }
}
