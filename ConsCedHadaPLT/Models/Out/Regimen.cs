using Newtonsoft.Json;

namespace ConsCedHadaPLT.Models.Out
{
    public partial class Regimen
    {
        [JsonProperty("codigo")]
        public long Codigo { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }
}
