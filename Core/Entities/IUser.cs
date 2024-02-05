namespace Core.Entities;
public interface IUser
{
    public Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    byte[] PasswordSalt { get; set; }
    byte[] PasswordHash { get; set; }
    bool Status { get; set; }
}