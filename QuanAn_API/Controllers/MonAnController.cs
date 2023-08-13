using Microsoft.AspNetCore.Mvc;
using QuanAn_API.Data;
using QuanAn_API.Model;

namespace QuanAn_API.Controllers
{
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private readonly QuanAnDBContext _dbContext;
        public MonAnController(QuanAnDBContext monanContext)
        {
            _dbContext = monanContext;
        }
        [HttpGet]
        [Route("/[Controller]/Create-MonAnEntity")]
        public IActionResult CreateLoai(MonAn monan)
        {
            var entity = _dbContext.monAns.Where(x => x.Id == monan.Id).FirstOrDefault();
            if (entity == null)
            {
                return BadRequest("The Id existed");
            }
            _dbContext.monAns.Add(entity);
            return Ok();
        }
    }
}
