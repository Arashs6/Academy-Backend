using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using AutoFixture;
using Framework.Core;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Services.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private static List<CourseDto> courses;

        public CourseController()
        {
            Fixture fixture = new Fixture();
            courses = fixture.CreateMany<CourseDto>(26).ToList();
        }

        [HttpGet]
        public PagedResult<CourseDto> GetAll(int skip,int pageSize )
        {
            
            var data = courses.Skip(skip).Take(pageSize).ToList();
            
            return new PagedResult<CourseDto>(data,courses.Count);
        }
    }
}