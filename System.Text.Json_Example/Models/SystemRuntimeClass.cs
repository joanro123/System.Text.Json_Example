using System.Runtime.Serialization;

namespace System.Text.Json_Example.Models
{
    [DataContract]
    public class SystemRuntimeClass
    {
        public SystemRuntimeClass(string lastName)
        : this(null, lastName, null)
        {
        }

        public SystemRuntimeClass(string? firstName, string lastName, int? age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string? FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; } = string.Empty;
        [DataMember(Name = "age", EmitDefaultValue = false)]
        public int? Age { get; set; }

    }
}
