using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Interfaces
{
    public interface IApplicationTypeRepo
    {

        IEnumerable<ApplicationType> ListAll();
        void Insert(ApplicationType applicationType);

    }
}
