using System.Text.Json_Example.Models;
using System.Text.Json_Example.Serialization;

string json;

SystemRuntimeClass systemRuntimeClass = new("System", "Runtime", 30);
SerializeWithSystemRuntime serializeWithSystemRuntime = new();

json = serializeWithSystemRuntime.Serialize(systemRuntimeClass);
Console.WriteLine(json);

var deserializedSystemRuntime = serializeWithSystemRuntime.Deserialize<SystemRuntimeClass>(json);
if (deserializedSystemRuntime is not null)
    Console.WriteLine($"{deserializedSystemRuntime.FirstName} {deserializedSystemRuntime.LastName} {deserializedSystemRuntime.Age}");

Console.WriteLine();

SystemTextClass systemTextClass = new("System", "Text", 40);
SerializeWithSystemText serializeWithSystemText = new();

json = serializeWithSystemText.Serialize(systemTextClass);
Console.WriteLine(json);

var deserializedSystemText = serializeWithSystemText.Deserialize<SystemTextClass>(json);
if (deserializedSystemText is not null)
    Console.WriteLine($"{deserializedSystemText.FirstName} {deserializedSystemText.LastName} {deserializedSystemText.Age}");




