namespace BlazorApp.Model
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonTitle { get; set; }
        public string LessonDescription { get; set; }

        //egy kapcsolat a Course felé
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
