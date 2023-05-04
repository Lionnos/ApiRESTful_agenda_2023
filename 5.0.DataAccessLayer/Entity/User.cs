namespace _5._0.DataAccessLayer.Entity
{
	public class User
	{
		public string idUser {get; set;}
		public string firstName {get; set;}
		public string surName {get; set;}
		public string email {get; set;}
		public string password {get; set;}
        public DateTime registerDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}