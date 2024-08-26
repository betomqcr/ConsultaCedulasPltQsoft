using Newtonsoft.Json;

namespace ConsCedHadaPLT.Models.Out
{
    public static class Serialize
    {
        public static string ToJson(this Response self) => JsonConvert.SerializeObject(self, ConsCedHadaPLT.Models.Out.Converter.Settings);
    }
}
