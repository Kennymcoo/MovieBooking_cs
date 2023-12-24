using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Models.Entities;

public class BaseEntity
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } 
}
