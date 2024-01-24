namespace Business.Dtos.Requests.ForeignLanguage
{
	public class UpdateForeignLanguageRequest
	{
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
		public string? Name { get; set; }
		public string? Level { get; set; }
	}
}
