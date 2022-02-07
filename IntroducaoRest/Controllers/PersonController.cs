using IntroducaoRest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroducaoRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IRepository_Person repository_Person;

        public PersonController(IRepository_Person repository_Person)
        {
            this.repository_Person = repository_Person;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var person = repository_Person.FindById(id);
            if(person == null) return NotFound();
            return Ok(person);
        }
    }
}
