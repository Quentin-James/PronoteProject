namespace Models;

public class Student
{
    public int Id { get; set; }

    // Propriété Nom de type chaîne de caractères, représente le nom de famille de l'élève
    public string Nom { get; set; }

    // Propriété Prenom de type chaîne de caractères, représente le prénom de l'élève
    public string Prenom { get; set; }

    public bool Sexe { get; set; }
    public DateTime Date_de_Naissance { get; set; }
    public virtual Classe? Classes { get; set; }

    public int Id_classe { get; set; }

    public ICollection<Grade>? Grades { get; set; }

    public ICollection<StudentParent>? StudentParents { get; set; }
    public virtual User? Users { get; set; }
    public int Id_user { get; set; }
}