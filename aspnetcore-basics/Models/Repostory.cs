using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_basics.Models
{
    public class Repostory
    {
        private static readonly List<Course> _courses = new();

        static Repostory()
        {
            _courses = new List<Course>
            {
                 new Course { Id = 1, Title = "Asp.Net Core 8.0", Description = "Asp.Net Core 8.0 Eğitimi",Image="1.jpg" },
                new Course { Id = 2, Title = "C# Temel", Description = "C# Temel Eğitimi", Image="2.jpg" },
                new Course { Id = 3, Title = "JavaScript Temel", Description = "JavaScript Temel Eğitimi", Image="3.jpg" }
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }


    }
}