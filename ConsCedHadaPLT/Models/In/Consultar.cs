using ConsCedHadaPLT.Models.Internos;

namespace ConsCedHadaPLT.Models.In
{
    public class Consultar
    {
        public Nombre Nombre { get; set; }
        public string cedula { get; set; }
        public bool factura { get; set; }
        public bool tiquete {  get; set; }
    }
}
