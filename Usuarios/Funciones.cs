using EspacioUsuario;

namespace EspacioFunciones
{
    public static class Funciones
    {
        public static void MostrarNUsuarios(int n, List<Usuario> listaUsuarios)
        {
            int mostrados = 0;
            foreach (Usuario usuario in listaUsuarios)
            {
                mostrados++;
                if (mostrados <= n)
                {
                    Console.WriteLine($"============== USUARIO {mostrados} ==============");
                    Console.WriteLine($"Nombre = {usuario.name}");
                    Console.WriteLine($"Correo Electronico = {usuario.          email}");
                    Console.WriteLine("===== DOMICILIO =====");
                    Console.WriteLine($"Cuidad = {usuario.address.city}");
                    Console.WriteLine($"Calle = {usuario.address.street}");
                    Console.WriteLine($"Suite = {usuario.address.suite}");
                }else{
                    break;
                }
            }
        }
    }
}