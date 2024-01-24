namespace Business.Dtos.Requests.Question
{
    public class UpdateQuestionRequest
    {
        public Guid Id { get; set; }
        public Guid? TrueAnswerId { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
