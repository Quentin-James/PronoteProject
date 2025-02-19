namespace Models;

public class Subject
{
    public int Id { get; set; }

    // Propriété Nom de type chaîne de caractères, représente le nom de famille de l'élève
    public string Nom { get; set; }

    public ICollection<Teacher>? Teachers { get; set; }
    public ICollection<Grade>? Grades { get; set; }
}