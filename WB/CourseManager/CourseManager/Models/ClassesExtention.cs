
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Classes
    {
        [Display(Name="班主任")]
        public string TeacherName
        {
            get {
                if (!TeacherId.HasValue)
                {
                    return "";
                }
                courseManagerEntities db = new courseManagerEntities();
                var teacher = db.Teacher.Where(t => t.Id == TeacherId.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}