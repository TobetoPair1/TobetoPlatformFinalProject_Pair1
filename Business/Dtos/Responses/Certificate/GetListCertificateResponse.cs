namespace Business.Dtos.Responses.Certificate
{
	public record GetListCertificateResponse(Guid Id, string Name, Guid UserId, string FilePath, string FileType);

}
