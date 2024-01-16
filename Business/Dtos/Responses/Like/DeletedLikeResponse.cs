namespace Business.Dtos.Responses.Like;

public class DeletedLikeResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public Guid Id { get; set; }

    public DeletedLikeResponse(bool isSuccess, string message, Guid id)
    {
        IsSuccess = isSuccess;
        Message = message;
        Id = id;
    }
}
