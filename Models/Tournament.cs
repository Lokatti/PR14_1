using System;
using System.Collections.Generic;

namespace ApiChessClub.Models
{
    public partial class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; } = null!;
    }
}
