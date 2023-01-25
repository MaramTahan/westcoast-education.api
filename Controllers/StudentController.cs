using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.api.Controllers;
    [ApiController]
    [Route("api/students")]
    public class StudentController : Controller
    {
        //http://localhost:5188/api/students
        [HttpGet()]
        public ActionResult List(){
            return Ok(new{
                message= "Students list done"
            });
        }


        [HttpGet("{userId}")]
        public ActionResult GetById(int userId){
            return Ok(new{
                message= $"GetStudentById.Nu {userId} is done"
            });
        }


        [HttpGet("personNu/{personNu}")]
        public ActionResult GetByPersonNu(string personNu){
            return Ok (new{ message= $"GetStudentByPersonNu {personNu} is done"});
        }


        [HttpGet("email/{email}")]
        public ActionResult GetByEmail(string email){
            return Ok (new{ message= $"GetStudentByEmail {email} is done"});
        }


        [HttpPost("addStudent/{userId}")]
        public ActionResult AddStudent(int userId){
            return Created(nameof(GetById), new{
                message = $"AddNewStudent with ID.Nu {userId} is done"
            });
        }


        [HttpPut("update/{userId}")]
        public ActionResult UpdateStudent(int userId){
            return NoContent();
        }


        [HttpGet("coursesRegistered/{userId}")]
        public ActionResult ListOfCoursesRegistered(int userId){
            return Ok(new{
                message= $"CoursesRegistered list of student with ID.Nu {userId} done"
            });
        }


        [HttpPost("registerNewCourse/{userId}")]
        public ActionResult RegisterNewCourse(int userId){
            return Created(nameof(GetById), new{
                message = $"Register a student with ID.Nu {userId} for new Course  is done"
            });
        }

    }