namespace Models.Models;

public class Subject
{
    /// <summary>
    /// Gets or sets the unique identifier of the subject.
    /// </summary>
   // public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the subject.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the collection of teachers associated with the subject.
    /// </summary>
    public ICollection<Teacher>? Teachers { get; set; }

    /// <summary>
    /// Gets or sets the collection of grades associated with the subject.
    /// </summary>
    public ICollection<Grade>? Grades { get; set; }
}