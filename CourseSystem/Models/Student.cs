//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Student_Courses = new HashSet<Student_Courses>();
        }
    
        public int id { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string School { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Courses> Student_Courses { get; set; }
    }
}
