using Microsoft.AspNetCore.Mvc;
using QuanAn_API.Data;
using QuanAn_API.Model;

namespace QuanAn_API.Controllers
{
    [ApiController]
    public class NguyenLieuController : ControllerBase
    {
        private readonly QuanAnDBContext _dbContext;
        public NguyenLieuController(QuanAnDBContext nguyenlieuContext)
        {
            _dbContext = nguyenlieuContext;
        }
        [HttpGet]
        [Route("/[Controller]/Create-NguyenLieuEntity")]
        public IActionResult CreateLoai(NguyenLieu nguyenlieu)
        {
            var entity = _dbContext.nguyenLieus.Where(x => x.Id == nguyenlieu.Id).FirstOrDefault();
            if (entity == null)
            {
                return BadRequest("The Id existed");
            }
            _dbContext.nguyenLieus.Add(entity);
            return Ok();
        }
    }
}
