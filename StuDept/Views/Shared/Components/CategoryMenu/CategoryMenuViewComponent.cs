using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StuDept.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuDept.Views.Shared.Components.CategoryMenu
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryMenuViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var departments = await dbContext.Departments.ToListAsync();
            return View(departments);
        }
    }
}
