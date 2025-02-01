using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LMStudioNET.Objects;
using LMStudioNET.Objects.Chat;
using LMStudioNET.Objects.Models;

namespace LMStudioNET
{
    public class LMStudioClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public LMStudioClient(string baseAddress = "http://127.0.0.1:1234")
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
        }

        public async Task<ModelListResponse> GetModelsAsync()
        {
            return await _httpClient.GetFromJsonAsync<ModelListResponse>(
                "/api/v0/models",
                _jsonOptions
            );
        }

        public async Task<Model> GetModelAsync(string modelId)
        {
            return await _httpClient.GetFromJsonAsync<Model>(
                $"/api/v0/models/{modelId}",
                _jsonOptions
            );
        }

        public async Task<ChatCompletionResponse> CreateChatCompletionAsync(ChatCompletionRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "/v1/chat/completions",
                request,
                _jsonOptions
            );
            return await response.Content.ReadFromJsonAsync<ChatCompletionResponse>(_jsonOptions);
        }

        public async IAsyncEnumerable<ChatCompletionChunk> StreamChatCompletionAsync(ChatCompletionRequest request)
        {
            request.Stream = true;
            var response = await _httpClient.PostAsJsonAsync(
                "/v1/chat/completions",
                request,
                _jsonOptions
            );

            using var stream = await response.Content.ReadAsStreamAsync();
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var chunk = await JsonSerializer.DeserializeAsync<ChatCompletionChunk>(
                    stream,
                    _jsonOptions
                );
                if (chunk != null) yield return chunk;
            }
        }
    }
}
