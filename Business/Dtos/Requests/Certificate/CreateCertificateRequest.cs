namespace Business.Dtos.Requests.Certificate;

	
public class CreateCertificateRequest
{
	public string Name { get; set; }
	public Guid UserId { get; set; }
	public string FilePath { get; set; }
	public string FileType { get; set; }
}
