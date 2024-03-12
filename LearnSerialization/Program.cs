using System.Text.Json;
using LearnSerialization;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var p1 = new Person()
{
  Name = "Tobi",
  Age = 25,
  Surname = "Wehrle",
  Address = new Address() { Street = "Neckargartacherstraße", Number = 420 }
};
var p2 = new Person()
{
  Name = "Alfred",
  Age = 31,
  Surname = "Müller",
  Address = new Address() { Street = "Buxingerstraße", Number = 42 }
};

p1.SerializeToFile("./person1.json");


var deserializedPerson = Person.DeserializeFromFile("./person1.json");

Console.WriteLine(deserializedPerson);

Console.WriteLine("---YAML---");


var yamlSerializer = new SerializerBuilder()
  .WithNamingConvention(CamelCaseNamingConvention.Instance)
  .Build();

var yaml = yamlSerializer.Serialize(p1);

Console.WriteLine("Person 1 as Serialized:");
Console.WriteLine(yaml);

File.WriteAllText("./person.yaml", yaml);

var dYaml = File.ReadAllText("./person.yaml");

var yamlDeserializer = new DeserializerBuilder()
  .WithNamingConvention(CamelCaseNamingConvention.Instance)
  .Build();

var yamlPerson = yamlDeserializer.Deserialize<Person>(dYaml);

Console.WriteLine("Person 1 as Deserialized:");

Console.WriteLine(yamlPerson);
