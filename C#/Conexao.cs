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
    class Conexao
    {
        MySqlConnection con;
        MySqlCommand cmd = new MySqlCommand();
        public Conexao()
        {
            string server = "cosmosbd.mysql.database.azure.com";
            string database = "CosmosHotel";
            string user = "cosmoshotel";
            string password = "Amoadrika123";
            string port = "3306";
            string sslM = "none";
            string AllowUserVariables = "True";
            string connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}; AllowUserVariables={6};", server, port, user, password, database, sslM, AllowUserVariables);
            con = new MySqlConnection(connString);
        }
        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void ConsultaObjeto(Object objeto)
        {
            try
            {
                cmd.Connection = Conectar();
                var propriedades = objeto.GetType().GetProperties();
                try
                {
                    string where = "WHERE";
                    foreach (var propriedade in propriedades)
                    {
                        if (propriedade.GetValue(objeto) != null && !propriedade.GetValue(objeto).Equals(0.0) && !propriedade.GetValue(objeto).Equals(0))
                        {
                            if (propriedade.PropertyType == typeof(double))
                            {
                                string _double = propriedade.GetValue(objeto).ToString().Replace(",", ".");
                                where += $" AND {propriedade.Name} = '{_double}'";
                            }
                            else
                            {
                                where += $" AND {propriedade.Name} = '{propriedade.GetValue(objeto)}'";
                            }
                        }
                    }
                    where = where.Replace("WHERE AND", "WHERE");
                    foreach (var propriedade in propriedades)
                    {
                        cmd.CommandText = $"SELECT {propriedade.Name} FROM tbl{objeto.GetType().Name} {where}";
                        string res;
                        res = cmd.ExecuteScalar().ToString();
                        if (propriedade.PropertyType == typeof(string))
                        {
                            propriedade.SetValue(objeto, res);
                        }
                        else if (propriedade.PropertyType == typeof(Int32))
                        {
                            propriedade.SetValue(objeto, Convert.ToInt32(res));
                        }
                        else if (propriedade.PropertyType == typeof(double))
                        {
                            propriedade.SetValue(objeto, Convert.ToDouble(res));
                        }
                        else if (propriedade.PropertyType == typeof(DateTime))
                        {
                            propriedade.SetValue(objeto, Convert.ToDateTime(res));
                        }
                    }
                    Desconectar();
                }
                catch
                {
                    Desconectar();
                    MessageBox.Show($"Não há nenhum(a) {objeto.GetType().Name} registrado(a) com os dados inseridos!", $"{objeto.GetType().Name} não encontrado(a)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CadastraObjeto(Object objeto)
        {
            try
            {
                cmd.Connection = Conectar();
                var propriedades = objeto.GetType().GetProperties();
                cmd.CommandText = $"INSERT INTO tbl{objeto.GetType().Name}(";
                foreach (var propriedade in propriedades)
                {
                    if (propriedade.GetValue(objeto) != null && !propriedade.GetValue(objeto).Equals(0.0) && !propriedade.GetValue(objeto).Equals(0))
                    {
                        cmd.CommandText += $"{propriedade.Name}, ";
                    }
                }
                cmd.CommandText += ") VALUES (";
                foreach (var propriedade in propriedades)
                {
                    if (propriedade.GetValue(objeto) != null && !propriedade.GetValue(objeto).Equals(0.0) && !propriedade.GetValue(objeto).Equals(0))
                    {
                        if (propriedade.PropertyType == typeof(double))
                        {
                            string _double = propriedade.GetValue(objeto).ToString().Replace(",", ".");
                            cmd.CommandText += $"'{_double}', ";
                        }
                        else
                        {
                            cmd.CommandText += $"'{propriedade.GetValue(objeto)}', ";
                        }
                    }
                }
                cmd.CommandText += ");";
                cmd.CommandText = cmd.CommandText.Replace(", )", ")");
                cmd.ExecuteNonQuery();
                if (objeto.GetType().GetField("NaoAvisarCadastro") == null)
                {
                    MessageBox.Show($"{objeto.GetType().Name} cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Desconectar();
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateObjeto(Object objeto)
        {
            try
            {
                cmd.Connection = Conectar();
                var propriedades = objeto.GetType().GetProperties();
                cmd.CommandText = $"UPDATE tbl{objeto.GetType().Name} SET ";
                string pk = objeto.GetType().GetField("primaryKey").GetValue(objeto).ToString();
                foreach (var propriedade in propriedades)
                {
                    if (propriedade.GetValue(objeto) != null && !propriedade.GetValue(objeto).Equals(0.0) && !propriedade.GetValue(objeto).Equals(0) && propriedade.Name != pk)
                    {
                        cmd.CommandText += $", {propriedade.Name} = ";
                        if (propriedade.PropertyType == typeof(double))
                        {
                            string _double = propriedade.GetValue(objeto).ToString().Replace(",", ".");
                            cmd.CommandText += $"'{_double}'";
                        }
                        else
                        {
                            cmd.CommandText += $"'{propriedade.GetValue(objeto)}'";
                        }
                    }
                }
                cmd.CommandText = cmd.CommandText.Replace("SET ,", "SET");
                cmd.CommandText += $" WHERE {pk} = '{objeto.GetType().GetProperty(pk).GetValue(objeto)}'";
                cmd.ExecuteNonQuery();
                if (objeto.GetType().GetField("NaoAvisarUpdate") == null)
                {
                    MessageBox.Show("Os dados foram alterados com sucesso!", "Alteração concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeletarObjeto(Object objeto)
        {
            try
            {
                string pk = objeto.GetType().GetField("primaryKey").GetValue(objeto).ToString();
                cmd.Connection = Conectar();
                cmd.CommandText = $"DELETE FROM tbl{objeto.GetType().Name} WHERE {pk} = '{objeto.GetType().GetProperty(pk).GetValue(objeto)}'";
                cmd.ExecuteNonQuery();
                if (objeto.GetType().GetField("NaoAvisarUpdate") == null)
                {
                    MessageBox.Show($"O registro do(a) {objeto.GetType().Name} foi excluído!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable ListarObjetos(Object objeto)
        {
            DataTable dt = new DataTable();
            var propriedades = objeto.GetType().GetProperties();
            try
            {
                cmd.Connection = Conectar();
                cmd.CommandText = $"SELECT * FROM tbl{objeto.GetType().Name} WHERE";
                foreach (var propriedade in propriedades)
                {

                    if (propriedade.GetValue(objeto) != null && !propriedade.GetValue(objeto).Equals(0.0) && !propriedade.GetValue(objeto).Equals(0))
                    {  
                        if (propriedade.PropertyType == typeof(double))
                        {
                            string _double = propriedade.GetValue(objeto).ToString().Replace(",", ".");
                            cmd.CommandText += $" AND {propriedade.Name} = '_double'";
                        }
                        else
                        {
                            cmd.CommandText += $" AND {propriedade.Name} LIKE '%{propriedade.GetValue(objeto)}%'";
                        }
                    }
                }
                cmd.CommandText = cmd.CommandText.Replace("WHERE AND", "WHERE");
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                Desconectar();
                return dt;
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ListarDetalhePedido(int idPedido)
        {
            try
            {
                cmd.Connection = Conectar();
                cmd.CommandText = $"SELECT idPedido, Descricao, p.idProduto as Codigo, a.Quantidade, Preco FROM tblProdutoPedido as a inner join tblProduto as p on a.idProduto = p.idProduto WHERE a.idPedido = '{idPedido}' UNION ALL SELECT idPedido, Descricao, p.idServico as Codigo, 1 as Quantidade, Preco FROM tblServicoPedido as a inner join tblServico as p on a.idServico = p.idServico WHERE a.idPedido = '{idPedido}';";
                DataTable dt = new DataTable();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                Desconectar();
                dt.Columns.Add("Custo");
                foreach (DataRow row in dt.Rows)
                {
                    row["Custo"] = (row["Preco"] != null) ? (Convert.ToDouble(row["Preco"]) * Convert.ToInt32(row["Quantidade"])).ToString("C") : null;
                }
                return dt;
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ListarQuartosDisponiveis(string checkin, string checkout, int idHotel, List<Quarto> quartos)
        {
            try
            {
                cmd.Connection = Conectar();
                cmd.CommandText = $"Set @var = 'Disponivel'; Select idQuarto, Capacidade, Número, Preco, usp_StatusQuarto('{checkin}', '{checkout}', idQuarto) as StatusQuarto from tblQuarto WHERE idHotel = '{idHotel}' AND usp_StatusQuarto('{checkin}', '{checkout}', idQuarto) = @var";
                if (quartos != null)
                {
                    foreach(Quarto quarto in quartos)
                    {
                        cmd.CommandText += $" AND idQuarto <> {quarto.idQuarto}";
                    }
                }
                DataTable dt = new DataTable();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                Desconectar();
                dt.Columns.Add("Custo");
                foreach (DataRow row in dt.Rows)
                {
                    row["Custo"] = (row["Preco"] != null) ? Convert.ToDouble(row["Preco"]).ToString("C") : null;
                }
                dt.Columns.Add("Descricao");
                foreach (DataRow row in dt.Rows)
                {
                    row["Descricao"] = (row["Capacidade"] != null) ? $"{row["Custo"]} - Quarto para {row["Capacidade"]} pessoas" : null;
                }
                return dt;
            }
            catch (MySqlException e)
            {
                Desconectar();
                MessageBox.Show("Ocorreu um erro na conexão com a base de dados: " + e, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
