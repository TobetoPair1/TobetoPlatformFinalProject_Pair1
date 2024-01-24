namespace Business.Dtos.Responses.Certificate
{
	public record DeletedCertificateResponse(Guid Id, string Name, Guid UserId, string FilePath, string FileType);
}
