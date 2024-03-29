﻿using System.Text.Json;

namespace System.Text.Json_Example.Serialization
{
    public class SerializeWithSystemText
    {
        public string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize(value);
        }

        public string SerializeWithOptions<T>(T value)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };

            return JsonSerializer.Serialize(value, options);
        }

        public T? Deserialize<T>(string json)
        {
                return JsonSerializer.Deserialize<T>(json);
        }



        public async Task<string> SerializeAsync<T>(T value)
        {
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, value);
            stream.Position = 0;
            using var reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        public ValueTask<T?> DeserializeAsync<T>(Stream json)
        {
            return JsonSerializer.DeserializeAsync<T>(json);
        }
        
    }
}
