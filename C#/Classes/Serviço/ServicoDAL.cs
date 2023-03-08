using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CosmosHotel
{
    class ServicoDAL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public ServicoDAL()
        {
        }
        public DataTable RegistraServico(Servico servico)
        {
            return null;
        }

        public DataTable ListarGrid(int _idHotel)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select idServico, Descricao, Preco from tblServico where idHotel = '{_idHotel}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }

        public DataTable Consulta(string _busca, int _idHotel)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select idServico, Descricao, Preco from tblServico where (idServico = '{_busca}' or Descricao like '%{_busca}%') and idHotel = '{_idHotel}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }
    }
}
