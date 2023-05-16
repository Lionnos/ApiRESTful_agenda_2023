using _0._0.DataTransferLayer.Dto;
using _4._0.RepositoryLayer.Generic;

namespace _4._0.RepositoryLayer.Repo
{
    public interface RepoUser : RepoGeneric<DtoUser>
    {
        public DtoUser GetByEmail(string idUser);
        public List<DtoUser> GetAll();
    }
}
