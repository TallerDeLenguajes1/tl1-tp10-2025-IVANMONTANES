using EspacioTarea;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace espacioFunciones
{
    public static class Funciones
    {

        // funcion para cargar las listas segun su estado //
        public static void CargarListaSegunEstado(List<Tarea> listaCompletadas, List<Tarea> listaPendientes, List<Tarea> listaTareas)
        {
            foreach (Tarea tarea in listaTareas)
            {
                if (tarea.completed)
                {
                    listaCompletadas.Add(tarea);
                }
                else
                {
                    listaPendientes.Add(tarea);
                }
            }
        }

        // funcion para mostra la lista //
        public static void MostrarLista(string NombreLista, List<Tarea> listaTareas)
        {
            Console.WriteLine($"=================== {NombreLista} =================");
            // verificamos que la lista no esta vacia //
            if (listaTareas.Count != 0)
            {
                foreach (Tarea tarea in listaTareas)
                {
                    Console.WriteLine("==========");
                    Console.WriteLine($"Titulo = {tarea.title}");
                    string estado = tarea.completed ? "Completada" : "Pendiente";
                    Console.WriteLine($"Estado: {estado}");
                }
            }
            Console.WriteLine($"=====================================================");

        }

        public static void GuardarListaJson(List<Tarea> listaTareas,string NombreArchivo)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string listaSerializada = JsonSerializer.Serialize(listaTareas,opciones);
            StreamWriter archivo = new StreamWriter(NombreArchivo);
            archivo.Write(listaSerializada);
            archivo.Flush();
        }
    }
}