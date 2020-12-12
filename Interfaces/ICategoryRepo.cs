using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Interfaces
{
    public interface ICategoryRepo
    {

        IEnumerable<Category> ListAll();
        void Insert(Category category);

    }
}
