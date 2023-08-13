using Microsoft.AspNetCore.Mvc;
using QuanAn_API.Data;
using QuanAn_API.Model;

namespace QuanAn_API.Controllers
{
    [ApiController]
    public class nhanvienController : ControllerBase
    {
        private readonly QuanAnDBContext _dbContext;
        public nhanvienController(QuanAnDBContext nhanvienContext)
        {
            _dbContext = nhanvienContext;
        }
        [HttpGet]
        [Route("/[Controller]/Create-NhanVienEntity")]
        public IActionResult Createnhanvien(NhanVien nhanvien)
        {
            var entity = _dbContext.nhanViens.Where(x => x.Id == nhanvien.Id).FirstOrDefault();
            if (entity == null)
            {
                return BadRequest("The Id existed");
            }
            _dbContext.nhanViens.Add(entity);
            return Ok();
        }
    }
}
