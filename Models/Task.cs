using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_ef.Models;

// [Table("Task")]
public class Task
{
    [Key]
    public Guid TaskId { get; set; }

    [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }

    // [Required]
    // [MaxLength(255)]
    public required string Titulo { get; set; }

    public required string Description { get; set; }

    public Priority PrioridadTarea { get; set; }

    public DateTime CreationAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual Category Category { get; set; }

    // [NotMapped]
    public string Resume { get; set; }
}

public enum Priority
{
    Low,
    Medium,
    High
}