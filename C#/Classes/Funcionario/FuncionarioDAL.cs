using System;
using CosmosHotel;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CosmosHotel
{
    class FuncionarioDAL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public FuncionarioDAL()
        {
        }

        public (Boolean, string, int, string) ValidaLoginDAL(string _cpf, string _senha, Funcionario funcionario) {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"select Count(CPF) from tblFuncionario where CPF = '{_cpf}'";
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    cmd.CommandText = $"select Count(CPF) from tblFuncionario where CPF = '{_cpf}' and Senha = '{_senha}'";
                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        funcionario.IDHotel = int.Parse(ConsultaDados("idHotel", _cpf));
                        funcionario.Nome = ConsultaDados("Nome", _cpf);
                        funcionario.CPF = ConsultaDados("Telefone", _cpf);
                        funcionario.Cargo = ConsultaDados("Cargo", _cpf);
                        funcionario.Email = ConsultaDados("Email", _cpf);
                        funcionario.Senha = ConsultaDados("Senha", _cpf);
                        conexao.Desconectar();
                        return (true, "Bem vindo ao sistema!", funcionario.IDHotel, funcionario.Cargo);
                    } else
                    {
                        conexao.Desconectar();
                        return (false, "Senha Inválida!", 0, "");
                    }
                }
                else 
                {
                    conexao.Desconectar();
                    return (false, "CPF Inválido!", 0, "");
                }
            }catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return (false, "Ocorreu um erro na conexão com a base de dados", funcionario.IDHotel, "");
            }
            
        }

        public string ConsultaDados(string _dado, string _cpf)
        {
            cmd.CommandText = $"select {_dado} from tblFuncionario where CPF = '{_cpf}'";
            return cmd.ExecuteScalar().ToString();
        }

        public string ConsultaDados(string _dado, string _cpf, int _idhotel)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"SELECT Count(*) FROM tblFuncionario where CPF = '{_cpf}' and idHotel = '{_idhotel}'";
                string count = cmd.ExecuteScalar().ToString();
                if (int.Parse(count) == 1)
                {
                    cmd.CommandText = $"Select {_dado} from tblFuncionario where CPF = '{_cpf}' and idHotel = '{_idhotel}' ";
                    string res = cmd.ExecuteScalar().ToString();
                    conexao.Desconectar();
                    return res;
                }
                else if (int.Parse(count) > 1)
                {
                    MessageBox.Show($"O dado {_dado}  esta relacionado a mais de um registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
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


        public string RegistraFuncionario(Funcionario funcionario)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"SELECT Count(*) FROM tblFuncionario where CPF = '{funcionario.CPF}'";
                string count = cmd.ExecuteScalar().ToString();
                if (int.Parse(count) == 0)
                {
                    cmd.CommandText = $"Insert into tblFuncionario (CPF, idHotel, Nome, Telefone, Cargo, Email, Senha) values('{funcionario.CPF}','{funcionario.IDHotel}','{funcionario.Nome}','{funcionario.Telefone}','{funcionario.Cargo}','{funcionario.Email}','{funcionario.Senha}')";
                    string resultado = cmd.ExecuteNonQuery().ToString();
                    conexao.Desconectar();
                    MessageBox.Show("Cadastrado com sucesso!", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }
                else
                {
                    MessageBox.Show("O funcionário já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public Boolean ModificaDados(Funcionario funcionario)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"UPDATE tblFuncionario SET Nome='{funcionario.Nome}', Telefone='{funcionario.Telefone}', Cargo='{funcionario.Cargo}', Email='{funcionario.Email}' where CPF = '{funcionario.CPF}' and idHotel = '{funcionario.IDHotel}'";
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

        public Boolean DeletaDados(Funcionario funcionario)
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = $"Select * from tblFuncionario where CPF = '{funcionario.CPF}' and idHotel = '{funcionario.IDHotel}' ";
                string cartao = cmd.ExecuteScalar().ToString();
                cmd.CommandText = $"DELETE from tblFuncionario where CPF = '{funcionario.CPF}' and idHotel = '{funcionario.IDHotel}'";
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Registro excluido!", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException e)
            {
                conexao.Desconectar();
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public DataTable ListarGrid(int _idhotel)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select CPF, Nome, Telefone, Cargo, Email from tblFuncionario where idHotel = '{_idhotel}' ";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }

        public DataTable Consulta(string _cpf, Index index)
        {
            Funcionario funcionario = new Funcionario(_cpf, index.funcionario.IDHotel);
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = $"Select CPF, Nome, Telefone, Cargo, Email from tblFuncionario where CPF = '{funcionario.CPF}' and idHotel = '{funcionario.IDHotel}'";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            conexao.Desconectar();
            return dt;
        }
    }
}