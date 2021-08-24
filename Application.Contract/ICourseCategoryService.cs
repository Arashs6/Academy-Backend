using System.Collections.Generic;

namespace Application.Contract
{
    public interface ICourseCategoryService
    {
        List<CourseCategoryDto> GetAll();
        void Delete(long id);
    }
}