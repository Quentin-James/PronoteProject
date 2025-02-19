namespace Models;

public class Grade
{
    public int Id { get; set; }

    // Propriété Nom de type chaîne de caractères, représente le nom de famille de l'élève
    public int Note { get; set; }

    public DateTime Date_Note { get; set; }
    public virtual Subject? Subjects { get; set; }
    public int Id_subject { get; set; }

    public virtual Student? Students { get; set; }
    public int Id_student { get; set; }
}