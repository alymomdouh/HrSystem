using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.Domain.Models
{
    public  class Attendance
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public bool Absent { get; set; }
        public int BonusHours { get; set; }
        public int DiscountHours { get; set; }
        [ForeignKey("Employee")]
        public int? EmpId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
