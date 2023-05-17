using _0._0.DataTransferLayer.Dto;
using _4._0.RepositoryLayer.Repo;
using _5._0.DataAccessLayer.Entity;
using _5._0.DataAccessLayer.Conection;


namespace _5._0.DataAccessLayer.Query
{
    public class QCity : RepoCity
    {
        public int Delete(string id)
        {
            throw new NotImplementedException();
        }

        public int Edit(DtoCity dto)
        {
            throw new NotImplementedException();
        }

        public List<DtoCity> GetAll()
        {
            using(DataBaseContext dbc = new())
            {
                List<City> listCity = dbc.Cities.ToList(); // select * from tcity
                List<DtoCity> listDtoCity = new(); 

                foreach (City item in listCity)
                {
                    DtoCity dtoCity = new();

                    dtoCity.idCity = item.idCity;
                    dtoCity.name = item.name;   
                    dtoCity.registerDate =  item.registerDate;
                    dtoCity.updateDate = item.updateDate;

                    listDtoCity.Add(dtoCity);
                }

                return listDtoCity;
            }
        }

        public DtoCity GetById(string id)
        {
            throw new NotImplementedException();
        }

        public int Insert(DtoCity dto)
        {
            throw new NotImplementedException();
        }
    }
}
