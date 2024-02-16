namespace Business.Dtos.Requests.UserOperationClaim
{
	public class DeleteUserOperationClaimRequest
	{
		public Guid UserId { get; set; }
		public Guid OperationClaimId { get; set; }
	}
}
