using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.Domain.Models
{
    public class ExceptionAttendance
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        //[CheckValidDate]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        //[ExceptionsCheckTime]
        public TimeSpan Start { get; set; }
        [DataType(DataType.Time)]
        //[ExceptionsCheckTime]
        public TimeSpan End { get; set; }
        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

    }
}
