using MKProject.UdemyBlog.DataAccess.Interfaces;
using MKProject.UdemyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>,IAppUserDal
    {
    }
}
