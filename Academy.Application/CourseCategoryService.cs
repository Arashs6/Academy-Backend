using System;
using System.Collections.Generic;
using System.Linq;
using Academy.Domain;
using Application.Contract;
using Mapster;

namespace Academy.Application
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _categoryRepository;

        public CourseCategoryService(ICourseCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<CourseCategoryDto> GetAll()
        {
            var entities =  _categoryRepository.GetAll();
            return entities.Adapt<List<CourseCategoryDto>>();
        }

        public void Delete(long id)
        {
            var entity = _categoryRepository.GetById(id);
            _categoryRepository.Delete(entity);
        }
    }
}