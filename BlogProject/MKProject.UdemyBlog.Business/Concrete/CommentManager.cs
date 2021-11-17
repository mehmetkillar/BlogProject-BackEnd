using MKProject.UdemyBlog.Business.Interfaces;
using MKProject.UdemyBlog.DataAccess.Interfaces;
using MKProject.UdemyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
        private readonly IGenericDal<Comment> _genericDal;
        public CommentManager(IGenericDal<Comment> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
