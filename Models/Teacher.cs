namespace Models;

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
    public string Nom { get; set; }

    /// <summary>
    /// Gets or sets the first name of the teacher.
    /// </summary>
    public string Prenom { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the teacher.
    /// </summary>
    public int Telephone { get; set; }

    /// <summary>
    /// Gets or sets the school associated with the teacher.
    /// </summary>
    public virtual School? Schools { get; set; }

    /// <summary>
    /// Gets or sets the subject associated with the teacher.
    /// </summary>
    public virtual Subject? Subjects { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated school.
    /// </summary>
    public int Id_school { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated subject.
    /// </summary>
    public int Id_subject { get; set; }

    /// <summary>
    /// Gets or sets the collection of courses associated with the teacher.
    /// </summary>
    public ICollection<Course>? Courses { get; set; }

    /// <summary>
    /// Gets or sets the user associated with the teacher.
    /// </summary>
    public virtual User? Users { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated user.
    /// </summary>
    public int Id_user { get; set; }
}