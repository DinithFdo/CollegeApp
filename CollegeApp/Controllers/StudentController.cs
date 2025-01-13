using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    [HttpGet]
    [Route("all",Name="GetAllStudents")]
    public IEnumerable<Student> GetStudents()
    {
        return CollegeRepository.Students;
    }

    [HttpGet]
    [Route("{id:int}", Name="GetStudentById")]
    public Student GetStudentById(int id)
    {
        return CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
    }
    
    [HttpGet]
    [Route("{name:alpha}", Name="GetStudentByName")]
    public Student GetStudentByName(string name)
    {
        return CollegeRepository.Students.Where(x=> x.StudentName == name).FirstOrDefault();
    }
    
    [HttpDelete]
    [Route("{id:int}", Name="DeleteStudent")]
    public bool DeleteStudentById(int id)
    {
        var student =  CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
        CollegeRepository.Students.Remove(student);
        return true;
    }
    
}