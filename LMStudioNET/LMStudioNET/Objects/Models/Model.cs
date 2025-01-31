using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMStudioNET.Objects.Models
{
    public class Model
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        [JsonPropertyName("arch")]
        public string Arch { get; set; }

        [JsonPropertyName("compatibility_type")]
        public string CompatibilityType { get; set; }

        [JsonPropertyName("quantization")]
        public string Quantization { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("max_context_length")]
        public int MaxContextLength { get; set; }
    }
}
