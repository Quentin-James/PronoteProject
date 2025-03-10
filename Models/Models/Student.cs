﻿namespace Models.Models;

using System.ComponentModel.DataAnnotations;

public class Student
{
    /// <summary>
    /// Gets or sets the unique identifier of the student.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the last name of the student.
    /// </summary>
    [Required]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the first name of the student.
    /// </summary>
    [Required]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the gender of the student.
    /// </summary>
    public bool Gender { get; set; }

    /// <summary>
    /// Gets or sets the birth date of the student.
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the class associated with the student.
    /// </summary>
    public virtual Classe? Class { get; set; }

    /// <summary>
    /// Gets or sets the collection of grades associated with the student.
    /// </summary>
    public ICollection<Grade>? Grades { get; set; }

    /// <summary>
    /// Gets or sets the collection of parent-student relationships.
    /// </summary>
    public ICollection<Parent>? Parents { get; set; }

    /// <summary>
    /// Gets or sets the user associated with the student.
    /// </summary>
    public virtual User? User { get; set; }
}