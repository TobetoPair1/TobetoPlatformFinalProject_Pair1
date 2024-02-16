namespace Business.Dtos.Requests.UserOperationClaim
{
	public class CreateUserOperationClaimRequest
	{
		public Guid UserId { get; set; }
		public Guid OperationClaimId { get; set; }
	}
}
