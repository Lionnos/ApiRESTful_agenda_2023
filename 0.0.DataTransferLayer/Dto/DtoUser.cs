using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.Dto
{
    public class DtoUser : DtoGeneric
    {
        public string idUser { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public List<DtoPerson> childPerson { get; set; }
    }
}
