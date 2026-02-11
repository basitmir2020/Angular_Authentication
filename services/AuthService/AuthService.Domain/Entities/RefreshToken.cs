namespace AuthService.Domain.Entities;

public class RefreshToken
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Token { get; set; } = default!;
    public DateTime ExpiryDate { get; set; }
    public bool IsRevoked { get; set; }
    public Guid UserId { get; set; }
}