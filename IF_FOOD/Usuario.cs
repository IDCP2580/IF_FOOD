using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_FOOD
{
    public class Usuario
    {
        int ID { get; }
        string user;
        string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        string senha;
        string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public Usuario()
        {

        }


    }
}
