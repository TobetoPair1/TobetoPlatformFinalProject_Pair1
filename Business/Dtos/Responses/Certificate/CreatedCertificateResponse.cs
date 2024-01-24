namespace Business.Dtos.Responses.Certificate
{
	public record CreatedCertificateResponse(Guid Id, string Name, Guid UserId, string FilePath, string FileType);
}
