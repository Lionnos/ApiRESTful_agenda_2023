using _5._0.DataAccessLayer.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._0.DataAccessLayer.Entity
{
    [Table("tcity")]

    public class City : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] // Decorador 
        public string idCity { get; set; }
        public string name { get; set; }

        #endregion
        #region children

        [InverseProperty("parentCity")]
        public List<Person> childPerson { get; set; }

        #endregion
    }
}