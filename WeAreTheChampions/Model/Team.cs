using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
   public class Team
    {      
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string TeamName { get; set; }
        public virtual ICollection<Player> Player { get; set; } = new HashSet<Player>();//nullable
        public TeamColor TeamColor { get; set; }
    }
}
