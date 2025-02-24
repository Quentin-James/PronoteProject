namespace Models.Models;

/// <summary>
/// Represents a parent.
/// </summary>
public class Parent
{
    /// <summary>
    /// Gets or sets the parent's identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the parent's last name.
    /// </summary>
    public string lastName { get; set; }

    /// <summary>
    /// Gets or sets the parent's first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the parent's phone number.
    /// </summary>
    public int Phone { get; set; }

    /// <summary>
    /// Gets or sets the collection of student-parent relationships.
    /// </summary>
    public ICollection<StudentParent>? StudentParents { get; set; }

    /// <summary>
    /// Gets or sets the user associated with the parent.
    /// </summary>
    public virtual User? Users { get; set; }
}