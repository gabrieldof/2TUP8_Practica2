using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej2;
namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpPost]
        public IActionResult CrearAlbumFotosEstandar([FromBody] int numpages)
        {


            if (numpages != 0)
            {
                PhotoBook photoBook = new PhotoBook(numpages);
                return Ok($"Se creó album estándar con {photoBook.GetNumberPages()} páginas");

            }
            else
            {
                PhotoBook photoBook = new PhotoBook();
                return Ok($"Se creó album estándar con {photoBook.GetNumberPages()} páginas");
            }
            
            
        }


    }
}
