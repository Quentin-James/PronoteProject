namespace Models;

/// <summary>
/// Represents a school.
/// </summary>
public class School
{
    /// <summary>
    /// Gets or sets the unique identifier of the school.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the school.
    /// </summary>
    public string Nom { get; set; }

    /// <summary>
    /// Gets or sets the collection of classes associated with the school.
    /// </summary>
    public ICollection<Classe>? Classes { get; set; }

    /// <summary>
    /// Gets or sets the collection of teachers associated with the school.
    /// </summary>
    public ICollection<Teacher>? Teachers { get; set; }
}