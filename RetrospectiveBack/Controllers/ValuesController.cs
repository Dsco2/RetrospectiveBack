using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public ValuesController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //_commentService.AddComment();

            var test = new List<Comment>
            {
                new Comment
                {
                    IdComment = 1,
                    Quote = "Clase de ejercicio",
                    User = "Daniel Cantor",
                    IdColumn = 1
                },
                new Comment
                {
                    IdComment = 2,
                    Quote = "Vamos aprendiendo React",
                    User = "Daniel Cantor",
                    IdColumn = 1
                },
                new Comment
                {
                    IdComment = 3,
                    Quote = "Aún no se hacer autenticación",
                    User = "Daniel Cantor",
                    IdColumn = 2
                },
                new Comment
                {
                    IdComment = 4,
                    Quote = "Porque es viernes",
                    User = "Daniel Cantor",
                    IdColumn = 3
                }
            };



            return Ok(test);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
