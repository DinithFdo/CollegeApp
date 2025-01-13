namespace CollegeApp.Models;

public static class CollegeRepository
{
    public static List<Student> Students = new List<Student>()
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