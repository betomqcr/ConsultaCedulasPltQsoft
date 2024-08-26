using Newtonsoft.Json;

namespace ConsCedHadaPLT.Models.Out
{
    public partial class Actividade
    {
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("codigo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Codigo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }
}
