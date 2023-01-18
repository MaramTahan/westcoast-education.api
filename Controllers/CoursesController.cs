using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.api.Controllers;

    [ApiController]
    [Route("api/c1/courses")]
    public class CoursesController : ControllerBase
    {
        [HttpGet()]
        public ActionResult List(){
            return Ok (new { message = "List work"});
        }

        [HttpGet("{id}")]

        public ActionResult GetById(int id){
            return Ok(new {message ="GetById work"});
        }

        [HttpGet("getbycourseno/{courseNo}")]

        public ActionResult GetByCourseNo(string courseNo){
            return Ok(new {message ="GetByCourseNo work"});
        }
        [HttpPost()]
        public ActionResult Add(object data){
            return Created(nameof(List), data);
        }


    }
