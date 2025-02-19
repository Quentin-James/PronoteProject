namespace Models;

public class Parent
{
    public int Id { get; set; }

    // Propriété Nom de type chaîne de caractères, représente le nom de famille de l'élève
    public string Nom { get; set; }

    // Propriété Prenom de type chaîne de caractères, représente le prénom de l'élève
    public string Prenom { get; set; }

    public int Telephone { get; set; }

    public ICollection<StudentParent>? StudentParents { get; set; }

    public virtual User? Users { get; set; }
    public int Id_user { get; set; }
}