namespace Business.Dtos.Responses.Certificate;


public class GetCertificateResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
    public string FileType { get; set; }
}


