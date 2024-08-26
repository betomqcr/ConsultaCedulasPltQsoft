using ConsCedHadaPLT.Models.Internos;

namespace ConsCedHadaPLT.Class
{
    public class Validaciones
    {

        public Nombre obtnerNombre(string[] nombre)
        {
			try
			{
                Nombre obtner = new Nombre();
				if(nombre.Length==3)
				{
                     = nombre[0] + " " + nombre[1];
                    string Apellido1 = Nombre[2];
                    string Apellido2 = Nombre[3];
                }

			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
