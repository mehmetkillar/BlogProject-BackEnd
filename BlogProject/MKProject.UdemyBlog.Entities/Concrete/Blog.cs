using MKProject.UdemyBlog.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.Entities.Concrete
{
    public class Blog : ITable
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
