using System.Collections.Generic;
using Academy.Application;
using Academy.Domain;
using Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Services.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseCategoryController : Controller
    {
        private readonly ICourseCategoryService _categoryService;

        public CourseCategoryController(ICourseCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public List<CourseCategoryDto> GetAll()
        {
            return _categoryService.GetAll();
        }
        
        [HttpDelete("{id:long}")]
        public void Delete(long id)
        {
            _categoryService.Delete(id);
        }
        [HttpPost]
        public void Post(CourseCategory courseCategory)
        {
            //....
        }
        
        
    }
}