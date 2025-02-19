namespace Models;

public class Absence
{
    public int Id { get; set; }
    public bool Justifie { get; set; }
    public DateTime Date_debut { get; set; }
    public DateTime Date_fin { get; set; }

    public virtual User? Users { get; set; }
}