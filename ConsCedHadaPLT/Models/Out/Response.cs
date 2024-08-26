using Newtonsoft.Json;

namespace ConsCedHadaPLT.Models.Out
{
    public partial class Response
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("tipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("regimen")]
        public Regimen Regimen { get; set; }

        [JsonProperty("situacion")]
        public Situacion Situacion { get; set; }

        [JsonProperty("actividades")]
        public List<Actividade> Actividades { get; set; }

        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json, ConsCedHadaPLT.Models.Out.Converter.Settings);

    }
}
