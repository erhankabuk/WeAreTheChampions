using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    public class TeamColor
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int? ColorId { get; set; }
        //public string ColorId { get; set; }
        public virtual Color Color { get; set; }
        public virtual Team Team { get; set; }

    }
}
