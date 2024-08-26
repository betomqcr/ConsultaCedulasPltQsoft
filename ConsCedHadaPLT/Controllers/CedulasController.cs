using ConsCedHadaPLT.Models.In;
using ConsCedHadaPLT.Models.Out;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace ConsCedHadaPLT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CedulasController : Controller
    {
        [HttpGet]

        public Helpers.ResponseGeneric<Consultar> ConsultaCedula(string dato)
        {
            try
            {
                Models.Out.Response respuesta = new Models.Out.Response();
                Consultar consultar = new Consultar();
                using (var client = new HttpClient())
                {
                    var task = Task.Run(async () =>
                {
                    return await client.GetAsync("https://api.hacienda.go.cr/fe/ae?identificacion=" + dato);
                }
                    );
                    HttpResponseMessage message = task.Result;

                    if (message.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    {
                        var task1 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        });
                        string mens = task1.Result;
                        ModelError error = JsonConvert.DeserializeObject<ModelError>(mens);
                        //lista.Add(error.Exceptionmessage);


                    }
                    else
                    {
                        var task2 = Task<string>.Run(async () =>
                        {
                            return await message.Content.ReadAsStringAsync();
                        });
                        string mens = task2.Result;
                        respuesta = JsonConvert.DeserializeObject<Response>(mens);

                        string[] Nombre = respuesta.Nombre.Split(" ");

                        string Nombre1 = Nombre[0]+" "+Nombre[1];
                        string Apellido1 = Nombre[2];
                        string Apellido2 = Nombre[3];

                        string estado = respuesta.Situacion.Estado;

                        if(respuesta.Actividades.Count!=0)
                        {
                            string factura = "s";
                        }
                        else
                        {
                            string factura = "N";
                        }

                    }
                }

                return new Helpers.ResponseGeneric<Consultar>("");
            }
            catch(Exception ex)
            {
                return new Helpers.ResponseGeneric<Consultar>("");
            }
        }
    }
}
