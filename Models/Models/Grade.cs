namespace Models.Models;

/// <summary>
/// Represents a grade assigned to a student for a subject.
/// </summary>
public class Grade
{
    /// <summary>
    /// Gets or sets the unique identifier of the grade.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the assigned grade.
    /// </summary>
    public int Note { get; set; }

    /// <summary>
    /// Gets or sets the date the grade was assigned.
    /// </summary>
    public DateTime GradeDate { get; set; }

    /// <summary>
    /// Gets or sets the subject associated with the grade.
    /// </summary>
    public virtual Subject? Subjects { get; set; }

    /// <summary>
    /// Gets or sets the student associated with the grade.
    /// </summary>
    public virtual Student? Students { get; set; }
}