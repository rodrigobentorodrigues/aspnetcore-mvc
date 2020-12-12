using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Interfaces
{
    public interface IApplicationTypeRepo
    {

        ApplicationType GetById(int? id);
        IEnumerable<ApplicationType> ListAll();
        void Delete(ApplicationType applicationType);
        void Insert(ApplicationType applicationType);
        void Update(ApplicationType applicationType);

    }
}
