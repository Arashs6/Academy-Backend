namespace Application.Contract
{
    public class CourseDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategoryDto CategoryDto { get; set; }
    }
}