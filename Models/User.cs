namespace Models;

using Microsoft.AspNetCore.Identity;

public class User : IdentityUser<int>
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public ICollection<Teacher>? Teachers { get; set; }
    public ICollection<Absence>? Absences { get; set; }

    public ICollection<Student>? Students { get; set; }

    public ICollection<Parent>? Parents { get; set; }
}