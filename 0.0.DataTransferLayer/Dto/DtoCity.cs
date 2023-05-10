using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.DTO
{
    internal class DtoCity : DtoGeneric
    {
        public string idCity { get; set; }
        public string name { get; set; }

        public List<DtoPerson> childPerson { get; set; }
    }
}
