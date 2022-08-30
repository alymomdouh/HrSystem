using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.Domain.Models
{
    public class WeeklyHoliday
    {
        [ForeignKey("GeneralSetting")]
        public int GeneralId { get; set; }
        public string Day { get; set; }
        public virtual GeneralSetting? GeneralSetting { get; set; }
    }
}
