// PETICION A LA API //
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Nodes;
using EspacioUsuario;

HttpClient cliente = new HttpClient();

// REALIZAMOS LA SOLICITUD GET //
HttpResponseMessage response = await cliente.GetAsync("https://jsonplaceholder.typicode.com/users");

// LANZA UNA EXEPCION SI LA PETICION NO FUE EXITOSA //
response.EnsureSuccessStatusCode();

// GUARDAMOS LA RESPUESTA EN UN STRING //
string responseBody = await response.Content.ReadAsStringAsync();

// DESERIALIZAMOS LA CADENA JSON A UNA LISTA DE OBJETOS //
List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);

// MOSTRAMOS LOS DATOS DE LOS PRIMEROS 5 USUARIOS //
int mostrados = 0;
foreach (Usuario usuario in listaUsuarios)
{
    mostrados++;
    if (mostrados <= 5)
    {
        Console.WriteLine($"============== USUARIO ==============");
        Console.WriteLine($"Nombre = {usuario.name}");
        Console.WriteLine($"Correo Electronico = {usuario.email}");
        Console.WriteLine("===== DOMICILIO =====");
        Console.WriteLine($"Cuidad = {usuario.address.city}");
        Console.WriteLine($"Calle = {usuario.address.street}");
        Console.WriteLine($"Suite = {usuario.address.suite}");
    }else{
        break;
    }
    
}
