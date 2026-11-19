using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class UsuarioBD
    {
        public string RecuperarLogin()
        {
            using(OracleConnection conn = ConexaoOracle.ObterConexao())
            using (OracleCommand cmdUsuario = new OracleCommand("SELECT NOME_USUARIO FROM G5_USUARIO", conn))
            using (OracleDataReader readerUsuario = cmdUsuario.ExecuteReader())

            using (OracleCommand cmd_senha = new OracleCommand("SELECT SENHA_USUARIO FROM G5_USUARIO", conn))
            using (OracleDataReader readerSenha = cmd_senha.ExecuteReader())



              

            return "a";
        }

        public bool CompararLogin(Usuario usuario)
        {
            
             
        }
    }
}
