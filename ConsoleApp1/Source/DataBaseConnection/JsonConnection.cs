using System;
using System.IO;
using System.Text.Json;

public class JsonConnection
{
    internal static string ConnectionDbURL = JsonSerializer.Deserialize<JsonConnection>("ConnectionDb.json");
}

