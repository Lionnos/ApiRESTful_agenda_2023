using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._0.DataAccessLayer.Entity
{
    [Table("tperson")]
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] // Decorador 
        public string idPerson { get; set; }
        public string idUser { get; set; }
        public string idCity { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}