using System;
using System.Collections.Generic;
using System.Linq;
using Academy.Domain;

namespace Academy.Persistence.EF.Repository
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        public List<CourseCategory> GetAll()
        {
            using var context = new AcademyContext();
            return context.CourseCategories.ToList()
                .Where(a => !a.ParentId.HasValue)
                .ToList();
        }

        public CourseCategory GetById(long id)
        {
            using var context = new AcademyContext();
            return context.CourseCategories.FirstOrDefault(a => a.Id == id);
        }

        public void Delete(CourseCategory entity)
        {
            using var context = new AcademyContext();
            context.Remove(entity);
            context.SaveChanges();
        }
    }
}