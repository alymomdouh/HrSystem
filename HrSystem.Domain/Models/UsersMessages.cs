using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem.Domain.Models
{
    public class UsersMessages
    {
        public int Id { get; set; }
        public string CurrentUserId { get; set; }
        public string otherUserId { get; set; }
        public string Message { get; set; }
    }
}
