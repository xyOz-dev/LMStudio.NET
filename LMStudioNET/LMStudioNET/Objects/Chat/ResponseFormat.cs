using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMStudioNET.Objects.Chat
{
    public class ResponseFormat
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("json_schema")]
        public JsonSchema JsonSchema { get; set; }
    }
}
