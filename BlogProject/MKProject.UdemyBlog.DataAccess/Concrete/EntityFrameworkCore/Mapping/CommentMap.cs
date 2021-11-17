using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MKProject.UdemyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MKProject.UdemyBlog.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.AutherName).HasMaxLength(100).IsRequired();
            builder.Property(I => I.AuthorEmail).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Description).HasMaxLength(400).IsRequired();

            builder.HasOne(I => I.ParentComment).WithMany(I => I.SubComment).HasForeignKey(I => I.ParentCommentId);
        }
    }
}
