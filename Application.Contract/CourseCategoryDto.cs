using System.Collections.Generic;

namespace Application.Contract
{
    public class CourseCategoryDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<CourseCategoryDto> Children { get; set; }   
    }
} 