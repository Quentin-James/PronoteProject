namespace Models;

public class School
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public ICollection<Classe>? Classes { get; set; }
    public ICollection<Teacher>? Teachers { get; set; }
}