using CourseMVC.Data;
using CourseMVC.Interfaces;
using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Utils
{
    public class ApplicationTypeRepoImpl : IApplicationTypeRepo
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicationTypeRepoImpl(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        public void Insert(ApplicationType applicationType)
        {
            dbContext.ApplicationTypes.Add(applicationType);
            dbContext.SaveChanges();
        }

        public IEnumerable<ApplicationType> ListAll()
        {
            return dbContext.ApplicationTypes;
        }
    }
}
