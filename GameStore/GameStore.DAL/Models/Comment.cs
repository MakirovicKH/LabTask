using GameStore.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Models
{
    public class Comment : BaseEntity
    {
        public string CommentMessage { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
