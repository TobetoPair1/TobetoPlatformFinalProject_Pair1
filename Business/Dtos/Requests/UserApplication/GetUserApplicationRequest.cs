namespace Business.Dtos.Requests.UserApplication;
    public class GetUserApplicationRequest
    {
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
    }
