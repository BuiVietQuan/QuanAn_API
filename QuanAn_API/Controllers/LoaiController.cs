using Microsoft.AspNetCore.Mvc;
using QuanAn_API.Data;
using QuanAn_API.Model;

namespace QuanAn_API.Controllers
{
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly QuanAnDBContext _dbContext;
        public LoaiController(QuanAnDBContext loaiContext) 
        {
            _dbContext = loaiContext;
        }
        [HttpGet]
        [Route("/[Controller]/Create-LoaiEntity")]
        public IActionResult CreateLoai(Loai loai)
        {
            var entity = _dbContext.loais.Where( x => x.Id==loai.Id).FirstOrDefault();
            if (entity == null) 
            {
                return BadRequest("The Id existed");
            }
            _dbContext.loais.Add(entity);
            return Ok();
        }
    }
}
