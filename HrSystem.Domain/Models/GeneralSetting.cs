using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.Domain.Models
{
    public class GeneralSetting
    {
        public GeneralSetting()
        {
            DaysOff = new List<WeeklyHoliday>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ValueOfExtra { get; set; }
        public int ValueOfDiscount { get; set; }
        public virtual List<WeeklyHoliday>? DaysOff { get; set; }
    }
}
