using Bookme.Models;

namespace Bookme.IHelper
{
    public interface IUserHelper
    {
        List<CommonDropDown> DropDownOfGender();
        List<Category> DropDownOfCategory();
    }
}
