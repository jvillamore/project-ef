using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_ef.Models;

[Table("Category")]
public class Category
{
    [Key]
    public Guid CategoryId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [MaxLength(255)]
    public string Description { get; set; }

    public virtual ICollection<Task> Tasks { get; set; }
}