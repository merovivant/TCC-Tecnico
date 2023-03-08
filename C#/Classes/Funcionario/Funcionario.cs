using CosmosHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmosHotel
{
    public class Funcionario
    {
        FuncionarioDAL sql = new FuncionarioDAL();
        public int IDHotel { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Funcionario(string _cpf,int _IDHotel ,string _nome, string _telefone, string _cargo, string _email, string _senha)
        {
            this.CPF = _cpf;
            this.IDHotel = _IDHotel;
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cargo = _cargo;
            this.Email = _email;
            this.Senha = _senha;
        }

        public Funcionario(string _cpf, string _senha)
        {
            this.CPF = _cpf;
            this.Senha = _senha;
        }

        public Funcionario(string _cpf, int _idhotel)
        {
            if (sql.ConsultaDados("CPF", _cpf, _idhotel) != null)
            {
                this.IDHotel = _idhotel;
                this.CPF = sql.ConsultaDados("CPF", _cpf, _idhotel);
                this.Nome = sql.ConsultaDados("Nome", _cpf, _idhotel);
                this.Telefone = sql.ConsultaDados("Telefone", _cpf, _idhotel);
                this.Cargo = sql.ConsultaDados("Cargo", _cpf, _idhotel);
                this.Email = sql.ConsultaDados("Email", _cpf, _idhotel);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public (Boolean, string, int, string) ValidaLogin()
        {
            return sql.ValidaLoginDAL(CPF, Senha, this);
        }

        public void CadastraFuncionario()
        {
            sql.RegistraFuncionario(this);
        }

        public Boolean ModificaFuncionario()
        {
            return sql.ModificaDados(this);
        }

        public Boolean DeletarFuncionario()
        {
            return sql.DeletaDados(this);
        }
    }
}