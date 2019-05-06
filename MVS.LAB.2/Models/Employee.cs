namespace MVS.LAB._2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }
        public Gender? Gender { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [Required]
        [Range(1000,10000)]
        public int Salary { get; set; }
         
        [ForeignKey("Department")]
        public int Dept_FK{ get; set; }
        public Department Department { get; set; }
    }
}
