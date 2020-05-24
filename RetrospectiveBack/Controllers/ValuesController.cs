using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ICommentService _commentService;

        public ValuesController(ICommentService commentService)
        {
            _commentService = commentService;
        }

       // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var data = _commentService.GetComments();

            return Ok(data);
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody] Comment comment)
        {
            _commentService.SetComment(comment);
            return true;
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
