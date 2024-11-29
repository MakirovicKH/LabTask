using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniqlo.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UptatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
