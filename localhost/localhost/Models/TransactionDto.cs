using System.ComponentModel.DataAnnotations;

public class TransactionDto
{
    [Range(1, int.MaxValue, ErrorMessage = "UserId должен быть > 0")]
    public int UserId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "CategoryId должен быть > 0")]
    public int CategoryId { get; set; }

    [Range(0.01, 1_000_000_000, ErrorMessage = "Amount должен быть положительным")]
    public decimal Amount { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }
}
