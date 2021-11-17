using MKProject.UdemyBlog.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
