namespace Business.Dtos.Requests.PersonalInfo
{
    public class GetPersonalInfoRequest
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
    }
}