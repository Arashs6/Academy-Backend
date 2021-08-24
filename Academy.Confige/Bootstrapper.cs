using System;
using System.ComponentModel.Design;
using Academy.Application;
using Academy.Domain;
using Academy.Persistence.EF.Repository;
using Application.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Confige
{
    public static class Bootstrapper
    {
        public static void AddAcademy(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            serviceCollection.AddTransient<ICourseCategoryService,CourseCategoryService>();
        }
    }
}