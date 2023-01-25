using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.api.Controllers;

    [ApiController]
    [Route("api/c1/courses")]
    public class CoursesController : ControllerBase
    {
        //http://localhost:5188/api/c1/courses
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
                message= $"GetCourseById.Nu {id} is done"
            });
        }


        [HttpGet("courseno/{courseNo}")]
        public ActionResult GetBycourseNumber(string courseNo){
            return Ok (new{ message= $"GetCourseBycourseNumber {courseNo} is done"});
        }

        [HttpGet("name/{name}")]
        public ActionResult GetByName(string name){
            return Ok (new{ message= $"GetCourseByName {name} is done"});
        }


        [HttpGet("startdate/{startDate}")]
        public ActionResult GetByStartDate(string startDate){
            return Ok (new{ message= $"GetCourseByStartDate {startDate} is done"});
        }

        [HttpPost("addCourse/{id}")]
        public ActionResult AddCourse(int id){
            return Created(nameof(GetById), new{
                message = $"AddNewCourse with Id.Nu {id} is done"
            });
        }


        [HttpPut("update/{id}")]
        public ActionResult UpdateCourse(int id){
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
