namespace Models.Models;

/// <summary>
/// Represents a class in a school.
/// </summary>
public class Classe
{
    /// <summary>
    /// Gets or sets the unique identifier of the class.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the class.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the level of the class.
    /// </summary>
    public string Level { get; set; }

    /// <summary>
    /// Gets or sets the school associated with the class.
    /// </summary>
    public virtual School? School { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated school.
    /// </summary>
    /// the below line is unnecassary, its automatic with the navigation property
    //public int IdSchool { get; set; }

    /// <summary>
    /// Gets or sets the collection of courses associated with the class.
    /// </summary>
    public ICollection<Course>? Courses { get; set; }

    /// <summary>
    /// Gets or sets the collection of students associated with the class.
    /// </summary>
    public ICollection<Student>? Students { get; set; }
}