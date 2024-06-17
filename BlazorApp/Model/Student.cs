namespace BlazorApp.Model
{
    public class Student
    {    
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        //több e több kapcsolat a coutse felé
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
