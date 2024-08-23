using Design_XCorePro.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Design_XCorePro.Repository.Interface;

namespace Design_XCorePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly InterfaceStudent _student;

        public StudentController(InterfaceStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult> GetStdList()
        {
            return Ok(await _student.GetStdList());
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            try
            {
                var result = await _student.AddStudent(student);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the server");
            }
        }

            [HttpDelete("{Id}")]

            public async Task<IActionResult> DeleteStudent(int Id)
            {
                try
                {
                    var result = await _student.DeleteStudent(Id);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data  from the server");
                }
            }

       
        [HttpPut]
        [Route("Student")]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            try
            {
                await _student.UpdateStudent(student);
                return Ok("Updated Successfully");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the server");
            }
        }
    }
}
    

