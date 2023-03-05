namespace DIP;

// This class is to spoof an appSettings.json file reader.
public static class AppSettingsReader
{
    public static string GetDbProvider()
    {
        return "SQLSERVER";
    }
}