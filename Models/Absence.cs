namespace Models;

/// <summary>
/// Represents an absence with its details.
/// </summary>
public class Absence
{
    /// <summary>
    /// Gets or sets the unique identifier of the absence.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the absence is justified.
    /// </summary>
    public bool Justifie { get; set; }

    /// <summary>
    /// Gets or sets the start date of the absence.
    /// </summary>
    public DateTime Date_debut { get; set; }

    /// <summary>
    /// Gets or sets the end date of the absence.
    /// </summary>
    public DateTime Date_fin { get; set; }

    /// <summary>
    /// Gets or sets the user associated with the absence.
    /// </summary>
    public virtual User? Users { get; set; }
}