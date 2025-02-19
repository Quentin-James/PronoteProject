namespace Models;

public class Classroom
{
    public int Id { get; set; }

    public string Nom { get; set; }

    public int Capacité { get; set; }

    public ICollection<Course>? Courses { get; set; }
}