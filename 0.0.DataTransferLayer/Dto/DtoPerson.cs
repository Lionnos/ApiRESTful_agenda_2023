using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.DTO
{
    internal class DtoPerson : DtoGeneric
    {
        public string idPerson { get; set; }
        public string idUser { get; set; }
        public string idCity { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public DtoUser parentUser { get; set; }
        public DtoCity parentCity { get; set; }
    }
}
