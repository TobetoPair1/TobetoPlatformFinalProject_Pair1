namespace Business.Dtos.Requests.ForeignLanguage
{
	public class CreateForeignLanguageRequest
	{
		public Guid UserId { get; set; }
		public string Name { get; set; }
		public string Level { get; set; }
	}
}
