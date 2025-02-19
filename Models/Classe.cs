namespace Models;

public class Classe
{
    public int Id { get; set; }

    // Propriété Nom de type chaîne de caractères, représente le nom de famille de l'élève
    public string Nom { get; set; }

    // Propriété Prenom de type chaîne de caractères, représente le prénom de l'élève
    public string Niveau { get; set; }

    public virtual School? Schools { get; set; }
    public int Id_school { get; set; }

    public ICollection<Course>? Courses { get; set; }
    public ICollection<Student>? Students { get; set; }
}