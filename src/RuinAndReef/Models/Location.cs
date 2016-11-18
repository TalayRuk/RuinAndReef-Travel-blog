using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RuinAndReefWithMigrations.Models
{
    

    [Table("Locations")] //Table name need to be plural 

    //class name to be the same as db table name that we will create 
    public class Location
    {
        [Key]
        //Set Primary Key for LocationId 
        public int LocationId { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        //add one to many relationship Location has many experiences
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
//next we need to create RuinAndReefDbContext.cs