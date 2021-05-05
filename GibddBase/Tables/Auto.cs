using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddBase.Tables
{
    [Table("Autos")]
    class Auto
    {
        public int Id { get; set; }

        public int AutoOwnerId { get; set; }
        [ForeignKey("AutoOwnerId")]
        public AutoOwner AutoOwner { get; set; }

        public string Reg_Number { get; set; }
        public string Type_body { get; set; }
        public string Color { get; set; }
        public float Volume { get; set; }
        public float Power { get; set; }
        public float Odometr { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Capacity { get; set; }
        public float Tonnage { get; set; }



    }
}
