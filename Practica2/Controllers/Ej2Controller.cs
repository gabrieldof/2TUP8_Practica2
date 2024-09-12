using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2.Ej2;
namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {

        // Lista estática para almacenar los álbumes
        private static List<PhotoBook> albumes = new List<PhotoBook>();

        [HttpPost("[action]")]
        public IActionResult CrearAlbumFotosEstandar([FromBody] int? numPages)
        {

            PhotoBook photoBook;
            if (numPages.HasValue && numPages != 0)
            {

                photoBook = new PhotoBook(numPages.Value);

            }
            else
            {
                photoBook = new PhotoBook();
                
            }

            albumes.Add(photoBook);

            return Ok($"Se creó album estándar con {photoBook.GetNumberPages()} páginas");


        }

        [HttpPost("[action]")]
        public IActionResult CrearAlbumFotosGrande()
        {
            albumes.Add(new BigPhotoBook());
            return Ok("se creo album grande de 64 paginas");
        }


        [HttpGet("[action]/{id}")]
        public IActionResult GetNumeroDePaginas(int id)
        {
            PhotoBook album = albumes.FirstOrDefault(p => p.Id == id);

            if (album != null)
            {
                return Ok(album.GetNumberPages());
            }
            else
            {
                return NotFound($"no se econtro album con el siguiente {id}");
            }
        }

        [HttpGet("[action]")]
        public IActionResult getAllBooks()
        {
            return Ok(albumes) ;
        }


    }
}
