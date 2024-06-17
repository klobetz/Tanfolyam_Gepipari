namespace BlazorApp.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }

        //kapcsolatok: egy a több kapcsolat a lesson osztállyal
        public virtual ICollection<Lesson> lessons { get; set; } = new List<Lesson>();

        //több a több kapcsolat a student felé
        public virtual ICollection<Student> Students { get; } = new List<Student>();

        //egy kapcsolat az Instructor felé
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
