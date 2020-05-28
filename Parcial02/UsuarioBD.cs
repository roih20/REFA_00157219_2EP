using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public  static class UsuarioBD
    {
        public static List<Usuario> UserList()
        {
            string consulta = "SELECT * FROM APPUSER";

            DataTable dt = Conexion.Consulta(consulta);
            
            List<Usuario> lista_user = new List<Usuario>();
            foreach (DataRow Row in dt.Rows)
            {
                Usuario user = new Usuario();
                user.idUser = Convert.ToInt32(Row[0].ToString());
                user.fullname = Row[1].ToString();
                user.username = Row[2].ToString();
                user.password = Row[3].ToString();
                user.userType = Convert.ToBoolean(Row[4].ToString());
                lista_user.Add(user);
            }

            return lista_user;
        }

        public static void cambiarContra(string username, string newPassword)
        {
            
            string sql = String.Format("UPDATE APPUSER SET password = '{0}' WHERE username = '{1}';", newPassword, username);
            Conexion.Accion(sql);
        }
    }
}