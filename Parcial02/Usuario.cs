using System;

namespace Parcial02
{
    public   class Usuario
    {

        public string username { get; set; }
        
        public string password { get; set; }
        
        public string fullname { get; set; }
        
        public bool userType { get; set; }
        
        public int idUser { get; set; }


        public Usuario()
        {
        }

        public Usuario(int n_idUser, string n_fullname, string n_username, string n_password, bool n_userType)
        {
            idUser = n_idUser;
            fullname = n_fullname;
            username = n_username;
            password = n_password;
            userType = n_userType;
        }
    }
}