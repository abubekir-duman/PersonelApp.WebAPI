namespace PersonelApp.WebAPI.Utilities;

public static class ExtensionMethods
{
    public static string ToErrorResult(this string value)
    {
        return ErrorResult.Failure(value);
    }
}
        
   