namespace localhost.Models;


public class User
{
    public int Id { get; set; }
    public string Username { get;  } = string.Empty;
    public string Email { get; } = string.Empty;

    public DateTime CreatedAt { get; set; } 
}

