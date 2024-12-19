using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopModel.Models.Base;

namespace WorkShopModel.Models
{
    public class WorkShopItem : BaseAuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public ICollection<Participant> Participants { get; set; }
    }
}
