using System.Collections.Generic;
using Application.Contract;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Services.RestApi.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        [HttpGet]
        public List<CourseDto> Get()
        {
            return new List<CourseDto>()
            {
                new CourseDto() {Id = 1, Title = "Android"},
                new CourseDto() {Id = 2, Title = "Ios"},
                new CourseDto() {Id = 3, Title = "Advance Android"}
            };
        }   
    }
}