namespace Models.Models;

/// <summary>
/// Represents a teacher.
/// </summary>
public class Teacher
{
    /// <summary>
    /// Gets or sets the unique identifier of the teacher.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the last name of the teacher.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the first name of the teacher.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the teacher.
    /// </summary>
    public int Phone { get; set; }

    /// <summary>
    /// Gets or sets the school associated with the teacher.
    /// </summary>
    public virtual School? Schools { get; set; }

    /// <summary>
    /// Gets or sets the subject associated with the teacher.
    /// </summary>
    public virtual Subject? Subjects { get; set; }

    /// <summary>
    /// Gets or sets the collection of courses associated with the teacher.
    /// </summary>
    public ICollection<Course>? Courses { get; set; }

    /// <summary>
    /// Gets or sets the user associated with the teacher.
    /// </summary>
    public virtual User? User { get; set; }
}