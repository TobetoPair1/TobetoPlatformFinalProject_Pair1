namespace Core.Utilities.Helpers.GuidHelpers;

public class GuidHelper
{
    public static string CreateGuid()
    {
        return Guid.NewGuid().ToString();
    }
}