using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{    
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }        
        public int Red { get; set; }
        public int Green{ get; set; }
        public int Blue { get; set; }
        public ICollection<TeamColor> TeamColors { get; set; } = new HashSet<TeamColor>();
        //public TeamColor TeamColors { get; set; }

        // colorları override edersin, datagridview'a Team'leri çekerken senin elinde o takıma ait Color Listesi teamcolors= 
        // [0]  Color()  color  Id colorname red green blue
        // [1]  Color()  colorıd colorname red green blue
        // teamcolors[0]  => Color class'ında override ettiğin stringi gösterir
        // datagridview'aTeam listesini vermeden önce  bimetohod için bu colorları gezip string ilke uç uça eklersen bu iş tamam
    }
}

