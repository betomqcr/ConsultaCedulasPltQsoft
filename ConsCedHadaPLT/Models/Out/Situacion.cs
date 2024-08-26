using Newtonsoft.Json;

namespace ConsCedHadaPLT.Models.Out
{
    public partial class Situacion
    {
        [JsonProperty("moroso")]
        public string Moroso { get; set; }

        [JsonProperty("omiso")]
        public string Omiso { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("administracionTributaria")]
        public string AdministracionTributaria { get; set; }
    }
}
