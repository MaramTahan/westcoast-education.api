using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.api.Controllers;
    [ApiController]
    [Route("api/teachers")]
    public class TeacherController : Controller
    {
        //http://localhost:5188/api/teachers
        [HttpGet()]
        public ActionResult List(){
            return Ok(new{
                message= "Teachers list done"
            });
        }


        [HttpGet("{userId}")]
        public ActionResult GetById(int userId){
            return Ok(new{
                message= $"GetTeacherById.Nu {userId} is done"
            });
        }


        [HttpGet("email/{email}")]
        public ActionResult GetByEmail(string email){
            return Ok (new{ message= $"GetTeacherByEmail {email} is done"});
        }


        [HttpPost("addTeacher/{userId}")]
        public ActionResult AddTeacher(int userId){
            return Created(nameof(GetById), new{
                message = $"AddNewTeacher with ID.Nu {userId} is done"
            });
        }


        [HttpPut("update/{userId}")]
        public ActionResult UpdateTeacher(int userId){
            return NoContent();
        }


        [HttpGet("coursesTaught/{userId}")]
        public ActionResult ListOfCoursesTaught(int userId){
            return Ok(new{
                message= $"CoursesTaught list of teacher with ID.Nu {userId} done"
            });
        }


        [HttpPost("addCourse/{courseId}")]
        public ActionResult AddCourse(int courseId){
            return Created(nameof(GetById), new{
                message = $"AddCourse with Course-Id.Nu {courseId} is done"
            });
        }
    }
