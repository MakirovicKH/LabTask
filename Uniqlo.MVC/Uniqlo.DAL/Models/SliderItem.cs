using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniqlo.DAL.Models
{
    public class SliderItem : BaseEntity
    {
        public string Title { get; set; }
        public string ButtonName { get; set; }
        public string ButtenUrl { get; set; }
        public string Image { get; set; }
    }
}
