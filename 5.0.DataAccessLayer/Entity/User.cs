using _5._0.DataAccessLayer.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._0.DataAccessLayer.Entity
{
    [Table("tuser")]

    public class User : EntityGeneric
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] // Decorador 
        public string idUser {get; set;}
		public string firstName {get; set;}
		public string surName {get; set;}
		public string email {get; set;}
		public string password {get; set;}

        [InverseProperty("parentUser")]
        public List<Person> childPerson { get; set; }

    }
}