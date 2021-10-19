﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public DateTime MatchDate { get; set; }
        public int? Team1Id { get; set; }//Nullable gereksiz 
        public virtual Team Team1 { get; set; }
        public int? Team2Id { get; set; }
        public virtual Team Team2 { get; set; }
        public int? Score1 { get; set; } = -1;
        public int? Score2 { get; set; } = -1;
        public Result? Result { get; set; }// "?" => nullable


        public string Team1Name()
        {            
            return Team1.TeamName;
        }
        public string Team2Name()
        {
            return Team2.TeamName;
        }
        public string MatchScoreFormat()
        {
            return (Score1 == null || Score2 == null) ? "? - ?" : $"{Score1} - {Score2}";
        }
        public string Team1TeamName => $"{Team1Name()}";
        public string Team2TeamName => $"{Team2Name()}";
        public string MatchScore => $"{MatchScoreFormat()}";

    }
}
