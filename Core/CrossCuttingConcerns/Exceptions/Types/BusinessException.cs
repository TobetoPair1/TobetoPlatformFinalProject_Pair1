namespace Core.CrossCuttingConcerns.Exceptions.Types;
public class BusinessException : Exception
{
    public BusinessException(string? message, string title) : base(message)
    {
        Title = title;
    }
    public string Title { get;  }
}