namespace Models.Models;

/// <summary>
/// Represents a course.
/// </summary>
public class Course
{
    /// <summary>
    /// Gets or sets the unique identifier of the course.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the start date of the course.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date of the course.
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Gets or sets the class associated with the course.
    /// </summary>
    public virtual Classe? Class { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated class.
    /// </summary>
    public int ClassId { get; set; }

    /// <summary>
    /// Gets or sets the classroom associated with the course.
    /// </summary>
    public virtual Classroom? Classroom { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated classroom.
    /// </summary>
    public int ClassroomId { get; set; }

    /// <summary>
    /// Gets or sets the teacher associated with the course.
    /// </summary>
    public virtual Teacher? Teacher { get; set; }
}