using System.Text.Json_Example.Models;
using System.Text.Json_Example.Serialization;
using Xunit;

namespace System.Text.Json_Test
{
    public class SerializationTests
    {
        [Fact]
        public void Test_Serialize_With_System_Runtimw()
        {
            SerializeWithSystemRuntime serializeWithSystemRuntime = new SerializeWithSystemRuntime();
            SystemRuntimeClass systemRuntimeClass = new("LastName");

            var serializedResult = serializeWithSystemRuntime.Serialize(systemRuntimeClass);

            Assert.Equal("{\"lastName\":\"LastName\"}", serializedResult);
        }

        [Fact]
        public void Test_Serialize_With_System_Text()
        {
            SerializeWithSystemText serializeWithSystemText = new SerializeWithSystemText();
            SystemTextClass systemTextClass = new("LastName");

            var serializedResult = serializeWithSystemText.Serialize(systemTextClass);

            Assert.Equal("{\"lastName\":\"LastName\"}", serializedResult);
        }
    }
}