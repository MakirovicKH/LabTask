using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniqlo.DAL.DTOs.SliderItemDTOs
{
    public class SliderItremDTO
    {
        [Required,Length(2,20)]
        public string Title { get; set; }

        [Required, Length(2, 20)]
        public string ButtonName { get; set; }

        [Required, Length(2, 20)]
        public string ButtenUrl { get; set; }

        [Required, Length(2, 20)]
        public string Image { get; set; }
    }
}
