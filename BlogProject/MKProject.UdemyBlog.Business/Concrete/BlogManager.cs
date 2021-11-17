using MKProject.UdemyBlog.Business.Interfaces;
using MKProject.UdemyBlog.DataAccess.Interfaces;
using MKProject.UdemyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MKProject.UdemyBlog.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>,IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;

        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Blog>> GetAllSortdByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(I => I.PostedTime);
        }
    }
}
