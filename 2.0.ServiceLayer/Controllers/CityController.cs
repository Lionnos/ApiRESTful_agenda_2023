using _0._0.DataTransferLayer.Dto;
using _3._0.BussinesLayer.Business;
using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult< List<DtoCity> > getAll()
        {
            BusinessCity businessCity = new ();

            return businessCity.getAll();   
        }
    }
}