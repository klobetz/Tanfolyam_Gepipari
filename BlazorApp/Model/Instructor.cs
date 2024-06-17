namespace BlazorApp.Model
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstuctorName { get; set; }

        //több kapcsolat a Course felé
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
