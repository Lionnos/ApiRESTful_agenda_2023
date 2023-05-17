using _0._0.DataTransferLayer.Dto;
using _4._0.RepositoryLayer.Repo;
using _5._0.DataAccessLayer.Query;

namespace _3._0.BussinesLayer.Business
{
    public class BusinessCity
    {
        public List<DtoCity> getAll()
        {
            RepoCity repoCity = new QCity();

            // Operaciones de negocio

            return repoCity.GetAll();
        }
    }
}
