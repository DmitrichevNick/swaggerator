using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Config
{
    /// <summary>
    ///     Path to Assembly
    /// </summary>
    [JsonPropertyName("assembly-path")]
    public string AssemblyPath { get; set; }

    /// <summary>
    ///     Class attributes to filter
    /// </summary>
    [JsonPropertyName("class-attributes")]
    public string[] ClassAttributes { get; set; }

    /// <summary>
    ///     Method attributes to filter
    /// </summary>
    [JsonPropertyName("method-attributes")]
    public string[] MethodAttributes { get; set; }

    internal static Config FromStreamReader(Stream stream)
    {
        return JsonSerializer.DeserializeAsync<Config>(stream).Result;
    }
}