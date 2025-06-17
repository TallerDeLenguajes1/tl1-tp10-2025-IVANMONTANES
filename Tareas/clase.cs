namespace EspacioTarea
{
    // clase para deserializar el json devuelto por la api //
    public class Tarea
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}