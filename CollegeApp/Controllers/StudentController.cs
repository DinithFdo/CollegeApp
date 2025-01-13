using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Student> GetStudentName()
    {
        return new List<Student>()
        {
            new Student
            {
                Id = 1,
                StudentName = "Dinith",
                Email = "dinith@email.com",
                Address = "108/A,Chilaw Road,Negombo."
            },
            new Student
            {
                Id = 2,
                StudentName = "Maleesha",
                Email = "maleesha@email.com",
                Address = "327/5,Mahahunupitiya,Negombo."
            }
        };
    }
}