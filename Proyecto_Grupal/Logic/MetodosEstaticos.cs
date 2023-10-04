using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class MetodosEstaticos
    {
        public static string GetHash(string contraseña)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(contraseña, 14);
        }

        public static bool CompararHash(string contraseña,  string hash) 
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(contraseña, hash);
        
        }
    }
}
