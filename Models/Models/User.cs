namespace Models.Models;

using Microsoft.AspNetCore.Identity;

/// <summary>
/// Represents a user in the system.
/// </summary>
public class User : IdentityUser<int>
{
    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the collection of teachers associated with the user.
    /// </summary>
    public virtual Teacher? Teacher { get; set; }

    /// <summary>
    /// Gets or sets the collection of absences associated with the user.
    /// </summary>
    public virtual ICollection<Absence>? Absences { get; set; }

    /// <summary>
    /// Gets or sets the collection of students associated with the user.
    /// </summary>
    public virtual Student? Student { get; set; }

    /// <summary>
    /// Gets or sets the collection of parents associated with the user.
    /// </summary>
    public virtual Parent? Parent { get; set; }
}