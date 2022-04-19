using System.Runtime.Serialization.Json;

namespace System.Text.Json_Example.Serialization
{
    public class SerializeWithSystemRuntime
    {
        public string Serialize<T>(T value)
        {
            using var stream = new MemoryStream();
            var serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(stream, value);
            var json = stream.ToArray();
            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public T? Deserialize<T>(string json)
        {
            DataContractJsonSerializer jsonSerializer = new(typeof(T));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            return (T?)jsonSerializer.ReadObject(stream);
        }
    }
}
