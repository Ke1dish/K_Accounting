using K_Accounting.Interfaces;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Debt : BaseEntity, ISoftDelete
{

    [Required]
    public int CounterpartyId { get; set; }

    [ForeignKey("CounterpartyId")]
    public virtual Counterparty Counterparty { get; set; }

    [Required]
    public int AccountId { get; set; }

    [ForeignKey("AccountId")]
    public virtual Account Account { get; set; }

    [Required]
    public DebtType Type { get; set; }

    [Required]
    public DateTime LoanDate { get; set; } = DateTime.Now;

    [Required]
    public DateTime DueDate { get; set; } = DateTime.Now.AddMonths(1);

    [Required]
    [Precision(18, 2)]
    public decimal InitialAmount { get; set; }

    [Required]
    [Precision(18, 2)]
    public decimal RemainingAmount { get; set; }

    [Required]
    public DebtStatus Status { get; set; } = DebtStatus.Active;

    [MaxLength(1000)]
    public string Comment { get; set; }

    public virtual ICollection<DebtPayment> Payments { get; set; } = new List<DebtPayment>();
}