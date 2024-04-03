using System;
using System.Collections.Generic;

namespace ApiChessClub.Models
{
    public partial class Teacher
    {
        public int TeachersId { get; set; }
        public decimal Price { get; set; }
        public int TeacherCategoryId { get; set; }
        public int? GroupsId { get; set; }
        public int UsersId { get; set; }

    }
}
