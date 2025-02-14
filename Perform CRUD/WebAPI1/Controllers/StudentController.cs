using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI1.Data;
using WebAPI1.Model;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private ApplicationDbContext _db;
        private readonly ILogger<StudentController> _logger;
        public StudentController(ApplicationDbContext context, ILogger<StudentController> logger)
        {
            _db = context;
            _logger = logger;
        }
        [HttpGet]
        public List<StudentEntity> GetStudents()
        {
            _logger.LogInformation("Fetching all student list");
            return _db.Students.ToList();
        }
        [HttpGet("GetStudentById")]
        public ActionResult<StudentEntity> GetStudentById(int id)
        {
            if(id <= 0)
            {
                _logger.LogError("Error... Id number is less than 1...");
                return BadRequest();
            }
            var student = _db.Students.FirstOrDefault(x => x.Id == id);
            if(student == null) {
                _logger.LogError("Student not found...");
                return NotFound();
            }
            _logger.LogInformation("Student found.");
            return student;
        }
        [HttpPost("NewAdmission")]
        public ActionResult AddStudent(StudentEntity student)
        {
            if(!ModelState.IsValid) {
                _logger.LogError("Invalid details...");
                return BadRequest(ModelState);
            }
            var studentDetails = _db.Students.FirstOrDefault(x => x.Id == student.Id);
            if(studentDetails != null)
            {
                _logger.LogError("Student id already taken...");
                return BadRequest("Student id already taken...");
            }
            _db.Students.Add(student);
            _db.SaveChanges();
            _logger.LogInformation("New student added...");
            return Ok(student);
        }
        [HttpPost("UpdateDetails")]
        public ActionResult UpdateDetails(int id, [FromBody] StudentEntity student)
        {
            if(id <= 0 && id == null)
            {
                _logger.LogError("Invalid details...");
                return BadRequest();
            }
            var studentDetails = _db.Students.FirstOrDefault(x => x.Id == id);
            if (studentDetails == null)
            {
                _logger.LogError("Student not found...");
                return NotFound();
            }
            studentDetails.Name = student.Name;
            studentDetails.Age = student.Age;
            studentDetails.Standard = student.Standard;
            studentDetails.EmailAddress = student.EmailAddress;
            _db.SaveChanges();
            _logger.LogInformation("Student details has been updated");
            return Ok(studentDetails);
        }
        [HttpPost("UpdateDetails1")]
        public ActionResult UpdateDetails1(StudentEntity student)
        {
            if (student == null)
            {
                _logger.LogError("Student not found...");
                return BadRequest();
            }
            var studentDetails = _db.Students.FirstOrDefault(x => x.Id == student.Id);
            if (studentDetails == null)
            {
                _logger.LogError("Student not found...");
                return NotFound();
            }
            studentDetails.Name = student.Name;
            studentDetails.Age = student.Age;
            studentDetails.Standard = student.Standard;
            studentDetails.EmailAddress = student.EmailAddress;
            _db.SaveChanges();
            _logger.LogInformation("Student details has been updated.");
            return Ok(studentDetails);
        }
        [HttpPost("RemoveStudent")]
        public ActionResult RemoveStudent(int id)
        {
            var student = _db.Students.FirstOrDefault(x => x.Id == id);
            if(student == null)
            {
                _logger.LogError("Student not found...");
                return NotFound();
            }
            _db.Students.Remove(student);
            _db.SaveChanges();
            _logger.LogInformation("Student details has been removed.");
            return Ok(student.Name + " is removed");
        }
    }
}
