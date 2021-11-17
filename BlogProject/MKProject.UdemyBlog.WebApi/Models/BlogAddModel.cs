﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKProject.UdemyBlog.WebApi.Models
{
    public class BlogAddModel
    {
        public int AppUserId { get; set; }
        public string Tittle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
    }
}
