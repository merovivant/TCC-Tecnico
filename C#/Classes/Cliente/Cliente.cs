using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    class Cliente: Conexao
    {
        ClienteDAL sql = new ClienteDAL();
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string idCartao { get; set; }

        public Cliente() { }

        public Cliente(string _cpf, string _idcartao, string _nome, string _email, string _estado, string _cidade, string _endereco)
        {
            this.CPF = _cpf.Replace(".", null).Replace("-", null);
            this.idCartao = _idcartao;
            this.Nome = _nome.Trim();
            this.Email = _email.Trim();
            this.Estado = _estado.Trim();
            this.Cidade = _cidade.Trim();
            this.Endereco = _endereco.Trim();
            this.Senha = "primeirasenha";
        }

        public Cliente(string key, string keyName)
        {
            if(keyName == "CPF")
            {
                this.CPF = key;
            } else if(keyName == "idCartao")
            {
                this.idCartao = key;
            }
            ConsultaObjeto(this);
        }

        public string CadastraCliente()
        {
            return sql.RegistraCliente(this);
        }

        public Boolean ModificaCliente(string _chave)
        {
            return sql.ModificaDados(this, _chave);
        }

        public Boolean DeletarRegistro(string _chave)
        {
            return sql.DeletaDados(_chave);
        }
    }
}
