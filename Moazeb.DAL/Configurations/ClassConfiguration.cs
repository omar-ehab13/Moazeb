using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Moazeb.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.HasData(
                new Class
                {
                    ClassName = "1A",
                    Grade = 1
                },
                new Class
                {
                    ClassName = "1B",
                    Grade = 1
                },
                new Class
                {
                    ClassName = "1C",
                    Grade = 1
                },
                new Class
                {
                    ClassName = "2A",
                    Grade = 2
                },
                new Class
                {
                    ClassName = "2B",
                    Grade = 2
                },
                new Class
                {
                    ClassName = "2C",
                    Grade = 2
                },
                new Class
                {
                    ClassName = "3A",
                    Grade = 3
                },
                new Class
                {
                    ClassName = "3B",
                    Grade = 3
                },
                new Class
                {
                    ClassName = "3C",
                    Grade = 3
                },
                new Class
                {
                    ClassName = "4A",
                    Grade = 4
                },
                new Class
                {
                    ClassName = "4B",
                    Grade = 4
                },
                new Class
                {
                    ClassName = "5A",
                    Grade = 5
                },
                new Class
                {
                    ClassName = "5B",
                    Grade = 5
                },
                new Class
                {
                    ClassName = "6A",
                    Grade = 6
                },
                new Class
                {
                    ClassName = "6B",
                    Grade = 6
                },
                new Class
                {
                    ClassName = "7A",
                    Grade = 7
                },
                new Class
                {
                    ClassName = "7B",
                    Grade = 7
                },
                new Class
                {
                    ClassName = "8A",
                    Grade = 8
                },
                new Class
                {
                    ClassName = "8B",
                    Grade = 8
                },
                new Class
                {
                    ClassName = "9A",
                    Grade = 9
                }
           );
        }
    }
}
