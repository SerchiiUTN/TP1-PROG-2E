using Entidades;

namespace Logic
{
    public class AutentificadorUsuario
    {
        private Archivos _gestorArchivos;

        public AutentificadorUsuario()
        {
            _gestorArchivos = new Archivos();
        }
       

        public T AutentificarUsuario<T>(string correo, string contraseña)
        {
           /* List<T> listaUsuarios = GetUsuarios<T>();
            foreach (T usuario in listaUsuarios)
            {
                if (correo == usuario. && contraseña == usuario.Clave)
                {
                    return true;
                }
            }*/
            throw new Exception("No coincide la contraseña o el correo");
        }

       public List<T> GetUsuarios<T> ()
        {
            try
            {
                string path = @"C:\PruebaLabNet\SistemaNewSysAcadUTN\Json\nuevoJson";
                List<T> listaUsuarios = _gestorArchivos.LeerJson<T>(path);
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
}
    }
}