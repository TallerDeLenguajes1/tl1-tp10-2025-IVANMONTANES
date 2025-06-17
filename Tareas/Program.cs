using System.Text.Json;
using System.Text.Json.Nodes;
using espacioFunciones;
using EspacioTarea;

// PETICION A LA API //
HttpClient client = new HttpClient();
// REALIZAMOS LA SOLICITUD GET // 
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
// LANZA UNA exepcion si la peticion no pudo realizarse correctamente //
response.EnsureSuccessStatusCode();
// LEEMOS LA RESPUESTA COMO UN STRING //
string responseBody = await response.Content.ReadAsStringAsync();
// DESERIALIZAMOS LA LISTA //
List<Tarea> listaTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);


// creamos 2 listas para las tareas pendientes y realizadas //
List<Tarea> listaPendientes = new List<Tarea>();
List<Tarea> listaCompletadas = new List<Tarea>();


// recorremos la lista //
Funciones.CargarListaSegunEstado(listaCompletadas, listaPendientes, listaTareas);


// mostramos ambas listas //
Funciones.MostrarLista("LISTA PENDIENTES", listaPendientes);
Funciones.MostrarLista("LISTA COMPLETADAS", listaCompletadas);


// serialiazamos la lista de tareas y la guardamos en un json //
Funciones.GuardarListaJson(listaTareas, "tareas.json");



