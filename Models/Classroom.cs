namespace Models;

/// <summary>
/// Represents a classroom.
/// </summary>
public class Classroom
{
    /// <summary>
    /// Gets or sets the unique identifier of the classroom.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the classroom.
    /// </summary>
    public string Nom { get; set; }

    /// <summary>
    /// Gets or sets the capacity of the classroom.
    /// </summary>
    public int Capacité { get; set; }

    /// <summary>
    /// Gets or sets the collection of courses associated with the classroom.
    /// </summary>
    public ICollection<Course>? Courses { get; set; }
}