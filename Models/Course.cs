namespace Models;

public class Course
{
    public int Id { get; set; }
    public DateTime Date_debut { get; set; }
    public DateTime Date_fin { get; set; }
    public virtual Classe? Classes { get; set; }
    public int Id_classe { get; set; }
    public virtual Classroom? Classrooms { get; set; }
    public int Id_classroom { get; set; }
    public virtual Teacher? Teachers { get; set; }
    public int Id_teacher { get; set; }
}