using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_FOOD
{
    public partial class w_Login : Form
    {
        public w_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           
        }

        public bool CompararLogin()
        {
            
            string filtroNome = txb_Username.Text;

            string SQL = "SELECT * FROM G5_USUARIO WHERE NOME_USUARIO LIKE " + filtroNome;


            using (OracleCommand cmd = new OracleCommand(SQL, ConexaoOracle.ObterConexao()))
            {
               
            }

            return true;
        }
        private void cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txb_Senha.PasswordChar = cb_MostrarSenha.Checked ? '\0' : '*'; 
        }

        private void btn_CancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
