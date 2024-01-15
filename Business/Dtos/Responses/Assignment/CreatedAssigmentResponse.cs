namespace Business.Dtos.Responses.Assignment
{
    public class CreatedAssigmentResponse
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int AssignmentTime { get; set; }
        public string AssignmentType { get; set; }
        public string VideoUrl { get; set; }
    }
}
