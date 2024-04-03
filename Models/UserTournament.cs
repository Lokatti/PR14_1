using System;
using System.Collections.Generic;

namespace ApiChessClub.Models
{
    public partial class UserTournament
    {
        public int UserTournamentsId { get; set; }
        public int UsersId { get; set; }
        public int TournamentId { get; set; }
    }
}
