using System;
using CosmosHotel;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    class ClienteDAL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public ClienteDAL(){

        }

        public string RegistraCliente(Cliente cliente)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"CALL usp_cadastroCliente('{cliente.CPF}','{cliente.idCartao}','{cliente.Nome}','{cliente.Email}','{cliente.Estado}','{cliente.Cidade}','{cliente.Endereco}','{cliente.Senha}')";
                string resultado = cmd.ExecuteScalar().ToString();
                conexao.Desconectar();
                return resultado;
            }
            catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return null;
            }

        }

        public string ConsultaDados(string _dado, string _chave)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"SELECT Count(*) FROM tblCliente where CPF = '{_chave}' or idCartao = '{_chave}'";
                string count = cmd.ExecuteScalar().ToString();
                if (int.Parse(count) != 0)
                {
                    cmd.CommandText = $"SELECT {_dado} FROM tblCliente where CPF = '{_chave}' or idCartao = '{_chave}'";
                    string res = cmd.ExecuteScalar().ToString();
                    conexao.Desconectar();
                    return res;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public Boolean ModificaDados(Cliente _cliente, string _chave)
        {   
            try {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"UPDATE tblCliente SET Nome='{_cliente.Nome}', Email='{_cliente.Email}', Estado='{_cliente.Estado}', Cidade='{_cliente.Cidade}', Endereco='{_cliente.Endereco}' where CPF = '{_chave}' or idCartao = '{_chave}'";
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return true;
            }
            catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public Boolean DeletaDados(string _chave)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"Select idCartao from tblCliente where CPF = '{_chave}'";
                string cartao = cmd.ExecuteScalar().ToString();
                cmd.CommandText = $"DELETE from tblCliente where CPF = '{_chave}'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE from tblCartao where idCartao = '{cartao}'";
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                return true;
            }
            catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}