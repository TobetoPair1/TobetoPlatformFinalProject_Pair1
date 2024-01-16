namespace Business.Dtos.Responses.Question
{
    public class CreatedQuestionResponse
    {
        public Guid TrueAnswerId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
