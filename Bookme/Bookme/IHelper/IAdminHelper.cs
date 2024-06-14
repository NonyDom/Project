using Bookme.Models;
using Bookme.ViewModels;

namespace Bookme.IHelper
{
    public interface IAdminHelper
    {
        Category GetCategoryById(int id);
        bool UpdateCategoryName(CategoryViewModel data);
    }
}
