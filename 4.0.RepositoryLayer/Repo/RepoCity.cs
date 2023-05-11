using _0._0.DataTransferLayer.Dto;
using _4._0.RepositoryLayer.Generic;

namespace _4._0.RepositoryLayer.Repo
{
    public interface RepoCity : RepoGeneric<DtoCity>
    {
        public List<DtoCity> GetAll();
    }
}