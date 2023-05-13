using Co.Brick_TestTask;

public class TypeFormatValidator 
{ 
    public static bool CanBeParsed(string str, FormatType type)
    {
        return type switch
        {
            FormatType.Number => int.TryParse(str, out var _),
            FormatType.Date => DateTime.TryParse(str, out var _),
            FormatType.TimeSpan => TimeSpan.TryParse(str, out var _),
            _ => throw new Exception($"Unknown format type '{type}'"),
        };
    }
}


