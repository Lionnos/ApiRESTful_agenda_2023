using _0._0.DataTransferLayer.Dto;

namespace _4._0.RepositoryLayer.Generic
{
    public interface RepoGeneric<Dto>
    {
        public int Insert(Dto dto);
        public int Edit(Dto dto);
        public int Delete(string id);

        public Dto GetById(string id);
    }
}
