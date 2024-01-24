namespace Business.Dtos.Responses.PersonalInfo
{
    public class CreatedPersonalInfoResponse
    {
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string IdentityNumber { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime BirthDate { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string District { get; set; }
		public string Address { get; set; }
		public string About { get; set; }
		public string ProfileImageUrl { get; set; }
	}
}
