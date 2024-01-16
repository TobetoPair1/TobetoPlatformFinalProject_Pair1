namespace Business.Dtos.Requests.Question
{
    public class CreateQuestionRequest
    {
        public Guid TrueAnswerId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
