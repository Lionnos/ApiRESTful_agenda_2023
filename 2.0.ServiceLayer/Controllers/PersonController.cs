using _0._0.DataTransferLayer.Dto;
using _3._0.BussinesLayer.Business;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<DtoPerson>> GetAll()
        {
            BusinessPerson businessPerson = new BusinessPerson();

            return null;
        }
    }
}
