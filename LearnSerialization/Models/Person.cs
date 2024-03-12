using System.Text.Json;
using System.Text.Json.Serialization;

namespace LearnSerialization;

public class Person
{
  public string Name { get; set; }
  [JsonPropertyName("lastname")]
  public string Surname { get; set; }
  public int Age { get; set; }
  public Address Address { get; set; }

  public void SerializeToFile(string path)
  {
    var json = JsonSerializer.Serialize<Person>(
      this,
      new JsonSerializerOptions()
      {
        WriteIndented = true,
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
      }
    );
    // check if file at path is already existing
    if (!File.Exists(path))
      File.Create(path).Close();
    File.WriteAllText(path, json);
  }
  public static Person DeserializeFromFile(string path)
  {
    if (!File.Exists(path))
      throw new FileNotFoundException("File not found", path);
    var json = File.ReadAllText(path);
    return JsonSerializer.Deserialize<Person>(json);
  }

  public override string ToString()
  {
    return $"""
        Name: {Name}
        Surname: {Surname}
        Age: {Age}
        Address: {Address.Street} {Address.Number}
        """;
  }
}

public class Address
{
  public string Street { get; set; }
  public int Number { get; set; }
}
