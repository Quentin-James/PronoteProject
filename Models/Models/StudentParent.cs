namespace Models.Models;

/// <summary>
/// Represents the relationship between a student and a parent.
/// </summary>
public class StudentParent
{
    /// <summary>
    /// Gets or sets the unique identifier of the relationship.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the student's identifier.
    /// </summary>
    public int StudentId { get; set; }

    /// <summary>
    /// Gets or sets the associated student.
    /// </summary>
    public virtual Student? Student { get; set; }

    /// <summary>
    /// Gets or sets the parent's identifier.
    /// </summary>
    public int ParentId { get; set; }

    /// <summary>
    /// Gets or sets the associated parent.
    /// </summary>
    public virtual Parent? Parent { get; set; }
}