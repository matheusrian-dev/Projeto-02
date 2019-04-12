using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    class ClassFuncionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }

        //ClassAcessoBD bd = new ClassAcessoBD();

        //public bool EsqueceuSenha(string recuperarEmail)
        //{
        //    bd.Conectar();
        //    DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Funcionario " +
        //        " WHERE email LIKE '" + recuperarEmail + "'"));
        //    bd.Desconectar();

        //    if (dt.Rows.Count == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        string emailInserido = dt.Rows[0]["email"].ToString();
        //        string senhaInserida = dt.Rows[0]["senha"].ToString();
        //        EnviarSenha(emailInserido, senhaInserida);
        //        return true;
        //    }
        //}


        //public void EnviarSenha(string recuperarEmail, string senha)
        //{
        //    var usuario = new SmtpClient("smtp.gmail.com", 587)
        //    {
        //        Credentials = new NetworkCredential("CentroSenai@gmail.com", "ti21tarde"),
        //        EnableSsl = true
        //    };
        //    usuario.Send("escolaEducacaoFuturo@gmail.com", recuperarEmail, "Email de Reenvio de senha.", "Sua senha é: " + senha + ".");

        //}

        //public DataTable RetFuncionario(string email, string senha)
        //{
        //    bd.Conectar();
        //    DataTable dt = bd.RetDataTable(String.Format("SELECT * " +
        //        " FROM Funcionario WHERE email LIKE '%{0}%' AND senha LIKE '%{1}%'", email, senha));
        //    bd.Desconectar();

        //    return dt;
        //}

        //public bool RealizarLogin()
        //{
        //    DataTable dt = RetFuncionario(Email, Senha);

        //    if (dt.Rows.Count > 0)
        //    {
        //        string nome = dt.Rows[0]["nomeFuncionario"].ToString();
        //        string cargo = dt.Rows[0]["cargo"].ToString();
        //        Nome = nome;
        //        Cargo = cargo;
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Email ou Senha inválido.");
        //        return false;
        //    }
        //}

        //public DataTable RetFrequenciaProfessor(string nome)
        //{
        //    bd.Conectar();
        //    DataTable dt = bd.RetDataTable(String.Format("SELECT * " +
        //        " FROM Funcionario WHERE nome LIKE '%{0}%' AND cargo LIKE 'professor(a)'", nome));
        //    bd.Desconectar();

        //    return dt;
        //}
    }
}
