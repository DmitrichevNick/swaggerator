using System.IO;

public class ConfigLoader
{
    public static Config LoadConfigByPath(string path)
    {
        using (var fileStream = File.OpenRead(path))
        {
            return Config.FromStreamReader(fileStream);
        }
    }
}