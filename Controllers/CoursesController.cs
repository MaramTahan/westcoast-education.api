using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.api.Controllers;

    [ApiController]
    [Route("api/c1/courses")]
    public class CoursesController : ControllerBase
    {
        [HttpGet()]
        public ActionResult List(){
            //ok creates a json result with the status code 200
            return Ok(new{
                message= "Courses list done"
            });
        }

        [HttpGet("{id}")]
        //http://localhost:5188/api/c1/courses/5

        public ActionResult GetById(int id){
            return Ok(new{
                message= $"GetById done {id}"
            });
        }

        [HttpGet("courseno/{courseNo}")]
        public ActionResult GetBycourseNumber(string courseNo){
            return Ok (new{ message= $"GetBycourseNumber done {courseNo}"});
        }

        [HttpGet("name/{name}")]
        public ActionResult GetByname(string name){
            return Ok (new{ message= $"GetByname done {name}"});
        }

        [HttpGet("startdate/{startDate}")]
        public ActionResult GetByStartDate(string startDate){
            return Ok (new{ message= $"GetByStartDate done {startDate}"});
        }

        [HttpPost()]
        public ActionResult AddCourse(){
            return Created(nameof(GetById), new{
                message = "AddCourse work"
            });
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCourse(int id){
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id){
            //go to database and delete course
            return NoContent();
        }

        [HttpPatch("fullybooked/{id}")]
        //go to database for mark course as fully booked
        public ActionResult MarkAsFullyBooked(int id){
            return NoContent();
        }

        [HttpPatch("done/{id}")]
        public ActionResult MarkAsDone(int id){
            return NoContent();
        }


    }
