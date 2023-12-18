namespace Business.Dtos.Responses.ForeignLanguage
{
	public class UpdatedForeignLanguageResponse
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Name { get; set; }
		public string Level { get; set; }
	}
}
