using Bookme.Database;
using Bookme.IHelper;
using Bookme.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookme.Helper
{
    public class UserHelper : IUserHelper
    {
        private readonly ApplicationDbContext _context;

        public UserHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CommonDropDown> DropDownOfGender()
        {
            try
            {
                var common = new CommonDropDown()
                {
                    Id = 0,
                    Name = "Select Gender"
                };
                var genderList = _context.CommonDropown.Where(x => x.Id > 0 && !x.Deleted).ToList();
                var drp = genderList.Select(x => new CommonDropDown
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList();
                drp.Insert(0, common);
                return drp;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        public List<Category> DropDownOfCategory()
        {
            try
            {
                var common = new Category()
                {
                    Id = 0,
                    Name = "Select Category"
                };
                var categoryList = _context.Category.Where(x => x.Id > 0 && !x.Deleted).ToList();
                var drp = categoryList.Select(x => new Category
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList();
                drp.Insert(0, common);
                return drp;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}
