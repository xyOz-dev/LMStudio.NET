﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMStudioNET.Objects.Chat
{
    public class Message
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("tool_call_id")]
        public string ToolCallId { get; set; }

        [JsonPropertyName("tool_calls")]
        public List<ToolCall> ToolCalls { get; set; }
    }
}
