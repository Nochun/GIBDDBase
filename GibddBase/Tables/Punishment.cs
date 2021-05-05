using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddBase.Tables
{
    class Punishment
    {
        public int Id { get; set; }
        public int AutoId { get; set; }
        [ForeignKey("AutoId")]
        public Auto Auto { get; set; }

        public int ViolationId { get; set; }
        [ForeignKey("ViolationId")]
        public Violation Violation { get; set; }

        public int OfficerId { get; set; }
        [ForeignKey("OfficerId")]
        public Officer Officer { get; set; }

        public float Cost { get; set; }
        public DateTime Date { get; set; }

        public DateTime? DateOfWithdrawal { get; set; }
        public DateTime? DateOfReturn { get; set; }

        public bool Paid { get; set; }


    }
}
