using MKProject.UdemyBlog.Business.Interfaces;
using MKProject.UdemyBlog.DataAccess.Interfaces;
using MKProject.UdemyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MKProject.UdemyBlog.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>,ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;

        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(I => I.Id);
        }
    }
}
