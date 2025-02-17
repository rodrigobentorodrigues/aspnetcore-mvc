﻿using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Interfaces
{
    public interface ICategoryRepo
    {

        IEnumerable<Category> ListAll();
        Category GetById(int? id);
        void Delete(Category category);
        void Insert(Category category);
        void Update(Category category);

    }
}
