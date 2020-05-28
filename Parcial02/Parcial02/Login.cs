namespace Parcial02
{
    public  static class Login
    {
        public static void logear()
        {
            string accion = $"SELECT * FROM APPUSER";
            
            Conexion.Accion(accion);
        }
    }
}