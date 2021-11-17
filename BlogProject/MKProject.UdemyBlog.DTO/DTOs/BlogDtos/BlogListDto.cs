using MKProject.UdemyBlog.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.DTO.DTOs.BlogDtos
{
    public class BlogListDto : IDto
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }
    }
}
