using System.Text.Json.Serialization;

namespace System.Text.Json_Example.Models
{
    public class SystemTextClass
    {

        public SystemTextClass(string lastName)
        : this(null, lastName, null)
        {
        }

        [JsonConstructor]
        public SystemTextClass(string? firstName, string lastName, int? age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        [JsonPropertyName("firstName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyOrder(order: 2)]
        public string? FirstName { get; set; }
        [JsonPropertyName("lastName"), JsonPropertyOrder(order: 3)]
        public string LastName { get; set; } = string.Empty;
        [JsonPropertyName("age"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonPropertyOrder(order: 1)]
        public int? Age { get; set; }
    }
}
