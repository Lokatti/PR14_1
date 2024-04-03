using System;
using System.Collections.Generic;

namespace ApiChessClub.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Creating { get; set; }
        public int TeachersId { get; set; }
        public int RequisitesId { get; set; }
    }
}
