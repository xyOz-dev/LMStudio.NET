using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMStudioNET.Objects.Chat
{
    public class FunctionParameters
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Dictionary<string, PropertyDefinition> Properties { get; set; }

        [JsonPropertyName("required")]
        public List<string> Required { get; set; }

        [JsonPropertyName("additional_properties")]
        public bool AdditionalProperties { get; set; }
    }
}
