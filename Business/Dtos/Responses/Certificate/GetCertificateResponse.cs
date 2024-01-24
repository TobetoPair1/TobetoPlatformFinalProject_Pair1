namespace Business.Dtos.Responses.Certificate
{
	public record GetCertificateResponse(Guid Id, string Name, Guid UserId, string FilePath, string FileType);
}
