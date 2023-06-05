using Core_Proje_Api.DAL.Apicontext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriyController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoriyList()
        {
            var c= new Context();
            return Ok (c.Categoriys.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            using var c = new Context();
            var values = c.Categoriys.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }
        [HttpPost]
        public IActionResult Categoriyadd(Categoriy p)
        {
                using var c = new Context();    
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            using var c = new Context();
            var values = c.Categoriys.Find(id);
            if(values == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
            c.SaveChanges ();
                return NoContent();
            }

        }
        [HttpPut]
        public IActionResult UpdateCategoriy(Categoriy p)
        {
            using var c = new Context();
            var values = c.Find<Categoriy>(p.Categoiryid);
            if (values==null)
            {
                return NotFound();

            }
            else 
            {
                values.CategoriyName = p.CategoriyName;
                
                c.Update(values); 
                c.SaveChanges () ;
                return NoContent();
            }
        }



    }
}
