using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Nodes;
using EspacioFunciones;
using EspacioUsuario;

// PETICION A LA API //
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
Funciones.MostrarNUsuarios(5, listaUsuarios);
