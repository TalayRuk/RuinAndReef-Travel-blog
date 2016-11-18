using System.ComponentModel.DataAnnotations;

namespace RuinAndReefWithMigrations.Models
{ //table name need to be plural according to naming convention!
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}