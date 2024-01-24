namespace Business.Dtos.Requests.Certificate
{
	public record CreateCertificateRequest (string Name, Guid UserId, string FilePath, string FileType);
}
