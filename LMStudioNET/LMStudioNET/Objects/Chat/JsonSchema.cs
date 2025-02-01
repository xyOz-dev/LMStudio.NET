using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace LMStudioNET.Objects.Chat
{
    public class JsonSchema
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("strict")]
        public string Strict { get; set; }

        [JsonPropertyName("schema")]
        public JsonElement Schema { get; set; }
    }
}
