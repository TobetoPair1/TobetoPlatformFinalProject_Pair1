namespace Business.Dtos.Responses.Education
{
	public class GetEducationResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string EducationLevel { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public int StartofDate { get; set; }
        public int GraduationYear { get; set; }
        public bool IsContinued { get; set; }
    }
}
