using Bookme.Database;
using Bookme.IHelper;
using Bookme.Models;
using Bookme.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Drawing.Text;

namespace Bookme.Helper
{
    public class AdminHelper : IAdminHelper
    {
        private readonly ApplicationDbContext _context;
        public AdminHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CheckEmail(string email)
        {
            var check = _context.ApplicationUser.Where(g => g.Email == email).FirstOrDefault();
            if (check != null) 
            { 
              return true;
            }
            return false;
        }

        public Category GetCategoryById(int id)
        {
            var category = _context.Category.FirstOrDefault(x  => x.Id == id && x.Active && !x.Deleted);
            if (category != null)
            {
                return category;
            }
            return null;
        }

        public bool UpdateCategoryName(CategoryViewModel data)
        {
            var checkCategory = _context.Category.Where(x => x.Id == data.Id && x.Active && !x.Deleted).FirstOrDefault();
            if (checkCategory != null)
            {
                checkCategory.Name = data.Name; 
                checkCategory.DateCreated = DateTime.Now;
                _context.Update(checkCategory);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
