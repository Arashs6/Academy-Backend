using System.Collections.Generic;

namespace Academy.Domain
{
    public interface ICourseCategoryRepository
    {
        List<CourseCategory> GetAll();
        CourseCategory GetById(long id);
        void Delete(CourseCategory entity);
    }
}